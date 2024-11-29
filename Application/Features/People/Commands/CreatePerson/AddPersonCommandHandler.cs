using Application.Abstraction;
using Domain.Entities;

namespace Application.Features.People.Commands.CreatePerson;

public class AddPersonCommandHandler : ICommandHandler<AddPersonCommand, bool>
{
    private readonly IPersonRepository _personRepository;

    public AddPersonCommandHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
    
    public async Task<bool> HandleAsync(AddPersonCommand command)
    {
        var person = new Person
        {
            Id = command.Id,
            FirstName = command.FirstName,
            LastName = command.LastName,
            BirthDate = command.BirthDate,
            Biography = command.Biography
        };
        
        await _personRepository.AddAsync(person);
        return true;
    }
}