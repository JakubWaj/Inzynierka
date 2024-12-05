using Application.Abstraction;
using Application.Features.Exceptions;

namespace Application.Features.Country.Commands.UpdateCountry;

public class UpdateCountryCommandHandler : ICommandHandler<UpdateCountryCommand,bool>
{
    private readonly ICountryRepository _countryRepository;

    public UpdateCountryCommandHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }
    
    public async Task<bool> HandleAsync(UpdateCountryCommand command)
    {
        var exists = await _countryRepository.ExistsAsync(command.Id);
        if (!exists)
        {
            throw new NotFoundException("Country not found");
        }
        var country = new Domain.Entities.Country
        {
            Id = command.Id,
            Name = command.Name
        };
        await _countryRepository.UpdateAsync(country);
        return true;
    }
}