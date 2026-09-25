using CandyOrg.Auth.Common;

namespace Models;

public class DbUser
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public bool IsAdmin { get; set; }
    public string HashedPassword { get; set; }
    public UserRoles Role { get; set; }
    public Guid EmployeeId { get; set; }
}