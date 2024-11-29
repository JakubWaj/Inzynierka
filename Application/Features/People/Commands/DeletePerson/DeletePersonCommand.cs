using Application.Abstraction;

namespace Application.Features.People.Commands.DeletePerson;

public class DeletePersonCommand : ICommand<bool>
{
    public Guid Id { get; set; }
}