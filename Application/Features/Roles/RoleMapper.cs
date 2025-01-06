using Application.Features.Movies;
using Application.Features.People;
using Application.Features.Reviews;
using Domain.Entities;

namespace Application.Features.Roles;

public static class RoleMapper
{
    public static RoleDto ToDto(this Role review)
    {
        return new RoleDto()
        {
            Id = review.Id,
            PersonId = review.PersonId,
            MovieId = review.MovieId,
            MovieProductionRole = review.MovieProductionRole,
            Character = review.Character,
            Score = (review.Reviews.Count>0? review.Reviews.Average(x => x.Rating):0),
            NumberOfReviews = review.Reviews.Count,
            Movie = review.Movie.ToDtoModel(),
            Person = review.Person.ToDto(),
        };
    }
    public static RolePersonDto ToDto(this Person person)
    {
        return new RolePersonDto(person.Id,person.FirstName,person.LastName,person.BirthDate,person.Biography,"");
    }
    public static IEnumerable<RoleDto> ToDto(this IEnumerable<Role> roles)
    {
        return roles.Select(x => x.ToDto());
    }
}