namespace SolmileGuesthouseAPI.DTO.NavigatorModel
{
    public class RoleCreateDto
    {
        public string Name { get; set; }
    }
    public class RoleReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class UserRoleDto
    {
        public int UserId { get; set; }
        public string Username { get; set; } = default!;
        public int RoleId { get; set; }
        public string RoleName { get; set; } = default!;
    }

    public class UpdateRoleAssignRequest
    {
        public string UserName { get; set; }
        public string RoleName { get; set; } = string.Empty;
    }
    public class RemoveUserRoleRequest
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }

    // Response DTOs
    public class ApiSuccessResponse
    {
        public string Message { get; set; }
        public string Position { get; set; }
    }

    public class ApiErrorResponse
    {
        public string Message { get; set; }
        public Dictionary<string, string[]> Errors { get; set; }
    }
}