﻿namespace Application.Features.People;

public record PersonDto(
    Guid Id,
    string FirstName,
    string LastName,
    DateTime BirthDate,
    string Biography
    );
