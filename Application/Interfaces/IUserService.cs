using CandyOrg.Result;
using Contracts.Requests;
using Contracts.Responses;

namespace Application.Interfaces;

public interface IUserService
{
        public Task<UserResponse?> GetUserByIdAsync(Guid userId);
    public Task<UserResponse?> GetUserByEmailAsync(string email);
    public Task<Result<UserResponse>> AddUserAsync(AddUserRequest userRequest);
}