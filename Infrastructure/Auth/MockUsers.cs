using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Auth;

public interface IMockUsers
{
    IEnumerable<User> GetUsers();
}

public class MockUsers : IMockUsers
{
    private readonly IPasswordHasher<User> _passwordHasher;

    public MockUsers(IPasswordHasher<User> passwordHasher)
    {
        _passwordHasher = passwordHasher;
    }

    public string Secure(string password) => _passwordHasher.HashPassword(null, password);

    public IEnumerable<User> GetUsers()
    {
        var users = new List<User>
        {
            new User
            {
                Id = Guid.NewGuid(),
                Login = "admin",
                Password = Secure("admin"),
                Email = "admin@gmail.com"
            }
        };
        return users;
    }


}