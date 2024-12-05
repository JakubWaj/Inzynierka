namespace API.Features.User.Requests;

public record UserSignInRequest(string Email, string Password);
public record UserSignUpRequest(string Login,string Email, string Password);