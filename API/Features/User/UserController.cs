﻿using API.Controllers;
using API.Features.User.Requests;
using Application.Abstraction;
using Application.Command.UserCommands.SignUpUser;
using Application.Features.Users;
using Application.Features.Users.Commands.RemoveFromFriends;
using Application.Features.Users.Commands.RespondToFriendRequest;
using Application.Features.Users.Commands.SendFriendRequest;
using Application.Features.Users.Commands.SignInUser;
using Application.Features.Users.Queries.GetAllUsers;
using Application.Features.Users.Queries.GetFriends;
using Application.Features.Users.Queries.GetFriendsRequests;
using Application.Features.Users.Queries.GetUser;
using Application.Features.Users.Queries.GetUserByEmail;
using Application.Features.Users.Queries.GetUserByLogin;
using Application.Features.Users.Queries.GetUsersActivity;
using Application.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Features.User;

public class UserController : BaseController
{
    private readonly IQueryDispatcher _queryDispatcher;
    private readonly ICommandDispatcher _commandDispatcher;
    private readonly ITokenStorage _tokenStorage;

    public UserController(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher, ITokenStorage tokenStorage)
    {
        _queryDispatcher = queryDispatcher;
        _commandDispatcher = commandDispatcher;
        _tokenStorage = tokenStorage;
    }
    
    [HttpPost("signin")]
    public async Task<ActionResult<JwtDto>> SignIn([FromBody] UserSignInRequest accountLogin)
    {
        var command = new SignInUserCommand(){Email = accountLogin.Email, Password = accountLogin.Password};
        var x = await _commandDispatcher.SendAsync(command);
        var jwt = _tokenStorage.Get();
        
        return jwt;
    }
    
    [HttpGet("all")]
    public async Task<ActionResult<IEnumerable<UserDto>>> GetAll()
    {
        var query = new GetUsersQuery();
        var users = await _queryDispatcher.SendAsync(query);
        return Ok(users);
    }
    
    [HttpPost("signup")]
    public async Task<ActionResult<JwtDto>> SignUp([FromBody] UserSignUpRequest accountSignUp)
    {
        Guid guid = Guid.NewGuid();
        var command = new SignUpUserCommand()
        {
            UserId = guid,
            Email = accountSignUp.Email, 
            Login = accountSignUp.Login,
            Password = accountSignUp.Password,
        };
        var result =  await _commandDispatcher.SendAsync(command);
        var jwt = _tokenStorage.Get();
        return jwt;
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<UserDto>> Get(Guid id)
    {
        var query = new GetUserQuery(){Id = id};
        var user = await _queryDispatcher.SendAsync(query);
        return user;
    }
    
    [HttpGet("email/{email}")]
    public async Task<ActionResult<UserDto>> GetByEmailAsync(string email)
    {
        var query = new GetUserByEmailQuery(){Email = email};
        var user = await _queryDispatcher.SendAsync(query);
        return user;
    }
    
    [HttpGet("login/{login}")]
    public async Task<ActionResult<UserDto>> GetByLoginAsync(string login)
    {
        var query = new GetUserByLoginQuery(){Login = login};
        var user = await _queryDispatcher.SendAsync(query);
        return user;
    }
    [HttpGet("me")]
    [Authorize]
    public async Task<ActionResult<UserDto>> Get()
    {
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        
        var guid = Guid.Parse(User.Identity?.Name);
        var query = new GetUserQuery(){Id = guid};
        var user = await _queryDispatcher.SendAsync(query);
        return user;
    }
    
    [HttpGet("requests")]
    [Authorize]
    public async Task<ActionResult<IEnumerable<UserFriendRequestDto>>> GetFriendRequests()
    {
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        
        var guid = Guid.Parse(User.Identity?.Name);
        var query = new GetFriendsRequestsQuery(){UserId = guid};
        var user = await _queryDispatcher.SendAsync(query);
        return Ok(user);
    }
    
    [HttpPost("requests/{friendId}")]
    [Authorize]
    public async Task<IActionResult> SendFriendRequest(Guid friendId)
    {
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        
        var guid = Guid.Parse(User.Identity?.Name);
        var command = new SendFriendRequestCommand()
        {
            UserId = guid,
            FriendId = friendId
        };
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(result);
    }
    
    [HttpPost("requests/{friendId}/accept")]
    [Authorize]
    public async Task<IActionResult> AcceptFriendRequest(Guid friendId)
    {
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        
        var guid = Guid.Parse(User.Identity?.Name);
        var command = new RespondToFriendRequestCommand()
        {
            UserId = guid,
            RequestId = friendId,
            Accept = true
        };
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(result);
    }
    
    [HttpPost("requests/{friendId}/reject")]
    [Authorize]
    public async Task<IActionResult> RejectFriendRequest(Guid friendId)
    {
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        
        var guid = Guid.Parse(User.Identity?.Name);
        var command = new RespondToFriendRequestCommand()
        {
            UserId = guid,
            RequestId = friendId,
            Accept = false
        };
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(result);
    }
    
    [HttpGet("friends")]
    [Authorize]
    public async Task<ActionResult<IEnumerable<UserDto>>> GetFriends()
    {
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        var guid = Guid.Parse(User.Identity?.Name);
        var query = new GetFriendsQuery(){Id = guid};
        var user = await _queryDispatcher.SendAsync(query);
        return Ok(user);
    }
    
    [HttpDelete("friends/{friendId}")]
    [Authorize]
    public async Task<IActionResult> DeleteFriend(Guid friendId)
    {
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        var guid = Guid.Parse(User.Identity?.Name);
        var command = new RemoveFromFriendsCommand()
        {
            UserId = guid,
            FriendId = friendId
        };
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(result);
    }
    
    [HttpGet("UsersActivity/{id}")]
    public async Task<ActionResult<ActivityDTO>> GetUsersActivity(Guid id)
    {
        var query = new GetUsersActivityQuery(){UserId = id};
        var user = await _queryDispatcher.SendAsync(query);
        return Ok(user);
    }
    [HttpGet("FriendsActivity")]
    [Authorize]
    public async Task<ActionResult<IEnumerable<ActivityDTO>>> GetFriendsActivity()
    {
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        var guid = Guid.Parse(User.Identity?.Name);
        var queryFriends = new GetFriendsQuery(){Id = guid};
        var friends = await _queryDispatcher.SendAsync(queryFriends);
        List<ActivityDTO> user = new();
        foreach (var friend in friends)
        {
            var friendActivity = await _queryDispatcher.SendAsync(new GetUsersActivityQuery(){UserId = friend.Id});
            user.Add(friendActivity);
        }
        return Ok(user);
    }
}

