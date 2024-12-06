using Application.Abstraction;
using Domain.Common.Enums;
using Domain.Entities;

namespace Application.Features.People.Commands.CreatePerson;

public class AddPersonCommand : ICommand<bool>
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Biography { get; set; }
    
}