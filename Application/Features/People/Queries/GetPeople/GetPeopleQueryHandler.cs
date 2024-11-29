using Application.Abstraction;
using Application.Features.People.Queries.GetPerson;
using Domain.Entities;

namespace Application.Features.People.Queries.GetPeople;

public class GetPeopleQueryHandler : IQueryHandler<GetPeopleQuery,IEnumerable<PersonDto>>
{
    private readonly IPersonRepository _personRepository;

    public GetPeopleQueryHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
    
    public async Task<IEnumerable<PersonDto>> HandleAsync(GetPeopleQuery query)
    {
        var people = await _personRepository.GetAllAsync();
        return people.ToDto();
    }
}