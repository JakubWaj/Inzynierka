namespace Application.Features.People;

public record PersonDto(
    Guid Id,
    string FirstName,
    string LastName,
    string Image,
    DateTime BirthDate,
    string Biography
    );
