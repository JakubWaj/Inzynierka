using API.Controllers;
using API.Features.User.Requests;
using Application.Abstraction;
using Application.Command.UserCommands.SignUpUser;
using Application.Features.Users;
using Application.Features.Users.Commands.SignInUser;
using Application.Features.Users.Queries.GetUser;
using Application.Features.Users.Queries.GetUserByEmail;
using Application.Features.Users.Queries.GetUserByLogin;
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
    
    [HttpPost("signup")]
    public async Task<IActionResult> SignUp([FromBody] UserSignUpRequest accountSignUp)
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
        if (!result)
        {
            return BadRequest("something went wrong!");  
        }
        /*return CreatedAtAction(nameof(Get), new {guid}, null);*/
        return Created($"api/account/{guid}", "User created successfully!");
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
    
}

