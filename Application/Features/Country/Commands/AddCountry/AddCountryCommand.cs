using Application.Abstraction;

namespace Application.Features.Country.Commands.AddCountry;

public class AddCountryCommand : ICommand<bool>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}