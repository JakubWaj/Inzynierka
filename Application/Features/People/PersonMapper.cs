using Application.Features.Roles;
using Domain.Entities;

namespace Application.Features.People;

public static class PersonMapper
{
    public static PersonDto ToDto(this Person person)
    {
        return new PersonDto(person.Id, person.FirstName , person.LastName,person.Image,person.BirthDate, person.Biography,0,0,person.Roles.Select(x => x.ToDtoPersonDto()));
    }
    
    public static IEnumerable<PersonDto> ToDto(this IEnumerable<Domain.Entities.Person> people)
    {
        return people.Select(x => x.ToDto());
    }
    public static PersonRolesDto ToDtoPersonDto(this Role review)
    {
        return new PersonRolesDto(review.Id,review.Movie.ToDtoModel(),review.MovieId,review.MovieProductionRole,review.Character,(review.Reviews.Count>0? review.Reviews.Average(x => x.Rating):0),review.Reviews.Count); 
    }
    
    private static decimal CalculateScore(this Domain.Entities.Person person) 
    {
        var Reviews = person.Roles.Select(x=>x.Reviews);
        var numberOfWatched = person.Roles.Select(x=>x.Reviews).Count();
        var ratings = Reviews.Select(x => x.Select(x => x.Rating));
        /*if(numberOfReviews == 0)
        {
            return 0;
        }
        decimal score = person.Roles.Sum(x => x.Reviews.Average(x => x.Rating));
        score /= numberOfReviews;*/
        return 0;
    }
    
}