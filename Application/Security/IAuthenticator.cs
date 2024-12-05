using Application.Features.Users;

namespace Application.Security;

public interface IAuthenticator
{
    JwtDto CreateToken(Guid userId);
}