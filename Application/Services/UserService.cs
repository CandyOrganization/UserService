using Application.Interfaces;
using Application.Interfaces.Repositories;
using Contracts.Responses;
using Mapster;

namespace Application.Services;

public class UserService : IUserService
{
    private IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserResponse?> GetUserById(Guid userId)
    {
        var user = await _userRepository.GetByIdAsync(userId);
        return user?.Adapt<UserResponse>();
    }

    public async Task<UserResponse?> GetUserByEmail(string email)
    {
        var user = await _userRepository.GetByEmailAsync(email);
        return user?.Adapt<UserResponse>();
    }
}