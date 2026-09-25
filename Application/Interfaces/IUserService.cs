using Contracts.Responses;

namespace Application.Interfaces;

public interface IUserService
{
    public Task<UserResponse?> GetUserById(Guid userId);
    public Task<UserResponse?> GetUserByEmail(string email);
}