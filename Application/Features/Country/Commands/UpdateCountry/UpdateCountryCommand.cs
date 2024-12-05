using Application.Abstraction;

namespace Application.Features.Country.Commands.UpdateCountry;

public class UpdateCountryCommand : ICommand<bool>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}