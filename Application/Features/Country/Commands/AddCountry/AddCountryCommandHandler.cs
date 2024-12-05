using Application.Abstraction;

namespace Application.Features.Country.Commands.AddCountry;

public class AddCountryCommandHandler : ICommandHandler<AddCountryCommand,bool>
{
    private readonly ICountryRepository _countryRepository;

    public AddCountryCommandHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }
    
    public async Task<bool> HandleAsync(AddCountryCommand command)
    {
        var country = new Domain.Entities.Country
        {
            Id = command.Id,
            Name = command.Name
        };
        await _countryRepository.AddAsync(country);
        return true;
    }
}