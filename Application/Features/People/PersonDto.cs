using Application.Features.Movies;
using Application.Features.Roles;
using Domain.Common.Enums;
using Domain.Entities;

namespace Application.Features.People;

public record PersonDto(
    Guid Id,
    string FirstName,
    string LastName,
    string Image,
    DateTime BirthDate,
    string Biography,
    IEnumerable<PersonRolesDto> Roles);

public record PersonRolesDto(
    Guid Id,
    MovieDtoModel Movie,
    Guid MovieId,
    MovieProductionRole MovieProductionRole,
    string? Character ,
    double Score,
    int NumberOfReviews);
