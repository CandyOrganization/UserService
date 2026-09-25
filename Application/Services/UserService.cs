using Application.Errors;
using Application.Interfaces;
using Application.Interfaces.Repositories;
using CandyOrg.Result;
using Contracts.Requests;
using Contracts.Responses;
using Mapster;
using Models;

namespace Application.Services;

public class UserService : IUserService
{
    private IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserResponse?> GetUserByIdAsync(Guid userId)
    {
        var user = await _userRepository.GetByIdAsync(userId);
        return user?.Adapt<UserResponse>();
    }

    public async Task<UserResponse?> GetUserByEmailAsync(string email)
    {
        var user = await _userRepository.GetByEmailAsync(email);
        return user?.Adapt<UserResponse>();
    }

    public async Task<Result<UserResponse>> AddUserAsync(AddUserRequest userRequest)
    {
        var user = await _userRepository.GetByEmailAsync(userRequest.Email);
        if (user is not null)
        {
            return Result<UserResponse>.ValidationError(new UserIsExistsError(userRequest.Email));
        }

        var dbUser = userRequest.Adapt<DbUser>();
        var result = await _userRepository.AddAsync(dbUser);
        return Result<UserResponse>.Success(result.Adapt<UserResponse>());
    }
}