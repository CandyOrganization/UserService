using System.ComponentModel.DataAnnotations;
using CandyOrg.Auth.Common;

namespace Contracts.Requests;

public class AddUserRequest
{
    [EmailAddress]
    public string Email { get; set; }
    public bool IsAdmin { get; set; }
    public string HashedPassword { get; set; }
    public UserRoles Role { get; set; }
    public Guid EmployeeId { get; set; }
}