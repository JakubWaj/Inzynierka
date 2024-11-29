using Application.Abstraction;
using Application.Features.Exceptions;

namespace Application.Features.People.Commands.DeletePerson;

public class DeletePersonCommandHandler : ICommandHandler<DeletePersonCommand,bool>
{
    private readonly IPersonRepository _personRepository;

    public DeletePersonCommandHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
    
    public async Task<bool> HandleAsync(DeletePersonCommand command)
    {
        var exists = await _personRepository.ExistsAsync(command.Id);
        if (!exists)
        {
            throw new NotFoundException("Person not found");
        }
        await _personRepository.DeleteAsync(command.Id);
        return true;
    }
}