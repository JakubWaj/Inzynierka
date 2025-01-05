using Application.Features.Roles;
using Domain.Entities;

namespace Application.Features.People;

public static class PersonMapper
{
    public static PersonDto ToDto(this Person person)
    {
        return new PersonDto(person.Id, person.FirstName , person.LastName,person.Image,person.BirthDate, person.Biography,person.Roles.Select(x => x.ToDtoPersonDto()));
    }
    
    public static IEnumerable<PersonDto> ToDto(this IEnumerable<Domain.Entities.Person> people)
    {
        return people.Select(x => x.ToDto());
    }
    public static PersonRolesDto ToDtoPersonDto(this Role review)
    {
        return new PersonRolesDto(review.Id,review.Movie.ToDtoModel(),review.MovieId,review.MovieProductionRole,review.Character,(review.Reviews.Count>0? review.Reviews.Average(x => x.Rating):0),review.Reviews.Count); 
    }
}