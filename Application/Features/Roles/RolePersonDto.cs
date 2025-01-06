namespace Application.Features.Roles;

public record RolePersonDto(Guid Id,string FirstName, string LastName, DateTime DateOfBirth, string Biography, string? PictureUrl);