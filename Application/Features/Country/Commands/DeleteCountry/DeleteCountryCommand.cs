using Application.Abstraction;

namespace Application.Features.Country.Commands.DeleteCountry;

public class DeleteCountryCommand : ICommand<bool>
{
    public Guid Id { get; set; }
}