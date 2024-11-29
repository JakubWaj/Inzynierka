using Application.Abstraction;

namespace Application.Features.People.Queries.GetPerson;

public class GetPersonQuery : IQuery<PersonDto>
{
    public Guid Id { get; set; }
}