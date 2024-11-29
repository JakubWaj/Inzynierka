using Application.Abstraction;
using Application.Features.Exceptions;
using Domain.Entities;

namespace Application.Features.People.Commands.UpdatePerson;

public class UpdatePersonCommandHandler : ICommandHandler<UpdatePersonCommand, bool>
{
    private readonly IPersonRepository _personRepository;

    public UpdatePersonCommandHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
    
    public async Task<bool> HandleAsync(UpdatePersonCommand command)
    {
        var exists = await _personRepository.ExistsAsync(command.Id);
        if (!exists)
        {
            throw new NotFoundException("Person not found");
        }
        var person = new Person
        {
            Id = command.Id,
            FirstName = command.FirstName,
            LastName = command.LastName,
            BirthDate = command.BirthDate,
            Biography = command.Biography
        };
        await _personRepository.UpdateAsync(person);
        return true;
        
    }
}
