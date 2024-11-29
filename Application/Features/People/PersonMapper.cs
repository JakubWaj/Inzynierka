using Domain.Entities;

namespace Application.Features.People;

public static class PersonMapper
{
    public static PersonDto ToDto(this Person person)
    {
        return new PersonDto(person.Id, person.FirstName , person.LastName,person.BirthDate, person.Biography);
    }
    
    public static IEnumerable<PersonDto> ToDto(this IEnumerable<Domain.Entities.Person> people)
    {
        return people.Select(x => x.ToDto());
    }
    
}