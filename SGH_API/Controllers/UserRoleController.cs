using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolmileGuesthouseAPI.Controllers
{
    [ApiController]
    [Route("api/userroles")] 
    //[Authorize(Roles = "Admin,HR,Manager")]  // Uncomment to enable authorization
    public class UserRoleController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;
        private readonly ILogger<UserRoleController> _logger;

        public UserRoleController(GuesthouseDbContext context, ILogger<UserRoleController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("all")]  
        public async Task<ActionResult<IEnumerable<UserRoleDto>>> GetUserRoles()
        {
            try
            {
                var userRoles = await _context.UserRoles
                    .Include(ur => ur.User)
                    .Include(ur => ur.Role)
                    .Select(ur => new UserRoleDto
                    {
                        UserId = ur.UserId,
                        Username = ur.User.Username,
                        RoleId = ur.RoleId,
                        RoleName = ur.Role.Name
                    })
                    .ToListAsync();

                return Ok(userRoles);
            }
            catch
            {
                return StatusCode(500, "An error occurred while retrieving user roles. Please try again later.");
            }
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateUserRoleAndPosition([FromBody] UpdateRoleAssignRequest request)
        {
            // Validate request
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiErrorResponse
                {
                    Message = "Validation failed",
                    Errors = ModelState.ToDictionary(
                        e => e.Key,
                        e => e.Value.Errors.Select(err => err.ErrorMessage).ToArray())
                });
            }

            try
            {
                var user = await _context.Users
                    .Include(e => e.UserRoles)
                    .FirstOrDefaultAsync(u => u.Username == request.UserName);

                if (user == null)
                    return NotFound(new ApiErrorResponse { Message = "User not found" });

                var role = await _context.Roles
                    .FirstOrDefaultAsync(r =>
                        EF.Functions.Collate(r.Name, "SQL_Latin1_General_CP1_CI_AS") ==
                        EF.Functions.Collate(request.RoleName, "SQL_Latin1_General_CP1_CI_AS"));

                if (role == null)
                    return NotFound(new ApiErrorResponse { Message = "Role not found" });

                // Update roles
                user.UserRoles.Clear();
                user.UserRoles.Add(new UserRole { RoleId = role.Id });

                // Update position
                var employee = await _context.Employees
                   .Include(e => e.UserRoles)
                   .FirstOrDefaultAsync(u => u.Username == request.UserName);
                employee.Position = GetPositionFromRoleName(role.Name);

                await _context.SaveChangesAsync();

                return Ok(new ApiSuccessResponse
                {
                    Message = "Role updated successfully",
                    Position = employee.Position
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating role for user {UserId}", request.UserName);
                return StatusCode(500, new ApiErrorResponse
                {
                    Message = "An error occurred while updating the role"
                });
            }
        }

        private static string GetPositionFromRoleName(string roleName)
        {
            return roleName.ToLower() switch
            {
                "admin" => "Administrator",
                "manager" => "Manager",
                "reception" => "Receptionist",
                "supervisor" => "Supervisor",
                "hr" => "Human Resources",
                "housekeeper" => "Housekeeper",
                "chauffer" => "Chauffer",
                _ => "Staff"
            };
        }
        [HttpDelete("remove")]
        public async Task<IActionResult> RemoveRole([FromBody] RemoveUserRoleRequest request)
        {
            if (request.UserId <= 0 || request.RoleId <= 0)
            {
                return BadRequest("Invalid userId or roleId.");
            }

            try
            {
                var userRole = await _context.UserRoles
                    .FirstOrDefaultAsync(ur => ur.UserId == request.UserId && ur.RoleId == request.RoleId);

                if (userRole == null)
                {
                    return NotFound("The specified role assignment was not found.");
                }

                // Remove the UserRole record
                _context.UserRoles.Remove(userRole);

                // Find the role name from the Role table
                var role = await _context.Roles.FirstOrDefaultAsync(r => r.Id == request.RoleId);

                // Find the user
                var Emp = await _context.Employees.FirstOrDefaultAsync(u => u.Id == request.UserId);

                if (Emp != null && role != null)
                {
                    // If user's position matches the role name, clear the position
                    if (Emp.Position == role.Name)
                    {
                        Emp.Position = null;
                    }
                }

                await _context.SaveChangesAsync();

                return Ok("Role successfully removed from the user.");
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while removing the role. Please try again later.");
            }
        }


    }
}
