using Application.Abstraction;
using Application.Features.Exceptions;

namespace Application.Features.People.Queries.GetPerson;

public class GetPersonQueryHandler : IQueryHandler<GetPersonQuery,PersonDto>
{
    private readonly IPersonRepository _personRepository;

    public GetPersonQueryHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
    
    public async Task<PersonDto> HandleAsync(GetPersonQuery query)
    {
        var exists = await _personRepository.ExistsAsync(query.Id);
        if (!exists)
        {
            throw new NotFoundException("Person not found");
        }
        var person = await _personRepository.GetAsync(query.Id);
        return person.ToDto();
    }
}
