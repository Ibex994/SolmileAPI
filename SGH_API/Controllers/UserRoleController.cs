using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data;
using SolmileGuesthouseAPI.Data.Models;

namespace SolmileGuesthouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,HR,Manager")]
    public class UserRoleController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;

        public UserRoleController(GuesthouseDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> GetUserRoles()
        {
            var userRoles = await _context.UserRoles
                .Include(ur => ur.User)
                .Include(ur => ur.Role)
                .Select(ur => new
                {
                    UserId = ur.UserId,
                    Username = ur.User.Username,
                    RoleId = ur.RoleId,
                    RoleName = ur.Role.Name
                })
                .ToListAsync();

            return Ok(userRoles);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole([FromBody] UserRole request)
        {
            var exists = await _context.UserRoles
                .AnyAsync(ur => ur.UserId == request.UserId && ur.RoleId == request.RoleId);

            if (exists)
                return Conflict("User already has this role.");

            _context.UserRoles.Add(new UserRole
            {
                UserId = request.UserId,
                RoleId = request.RoleId
            });

            await _context.SaveChangesAsync();
            return Ok("Role assigned to user.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveRole(int userId, int roleId)
        {
            var userRole = await _context.UserRoles
                .FirstOrDefaultAsync(ur => ur.UserId == userId && ur.RoleId == roleId);

            if (userRole == null)
                return NotFound("Role assignment not found.");

            _context.UserRoles.Remove(userRole);
            await _context.SaveChangesAsync();

            return Ok("Role removed from user.");
        }
    }

}
