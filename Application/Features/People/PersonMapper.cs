using Application.Features.Roles;
using Domain.Entities;

namespace Application.Features.People;

public static class PersonMapper
{
    public static PersonDto ToDto(this Person person)
    {
        return new PersonDto(person.Id, person.FirstName , person.LastName,person.Image,person.BirthDate, person.Biography,CalculateScore(person),person.Roles.SelectMany(x => x.Reviews).Where(x=>x.Rating>0).Count(),person.Roles.Select(x => x.ToDtoPersonDto()));
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
        var Reviews = person.Roles.SelectMany(x => x.Reviews).Where(x=>x.Rating>0);
        var ratings = Reviews.Select(x=>x.Rating);
        if(Reviews.Count() == 0)
        {
            return 0;
        }
        decimal score = ratings.Sum()/Reviews.Count();
        return score;
    }
}