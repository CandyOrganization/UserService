using Application.Interfaces;
using CandyOrg.Controllers.Controllers;
using Contracts.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class PrivateUserController : BaseAuthController
{
    private IUserService _userService;

    public PrivateUserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("private/user/{userId}")]
    public async Task<IActionResult> GetUserById(Guid userId)
    {
        var user = await _userService.GetUserById(userId);

        if (user is null)
        {
            return NotFound();
        }

        return Ok(user);
    }
    
    [HttpGet("private/user")]
    public async Task<IActionResult> GetUserById([FromQuery] string email)
    {
        var user = await _userService.GetUserByEmail(email);

        if (user is null)
        {
            return NotFound();
        }
        
        return Ok(user);
    }

    [HttpPost("private/user")]
    public async Task<IActionResult> AddUser(AddUserRequest request)
    {
        
    }
}