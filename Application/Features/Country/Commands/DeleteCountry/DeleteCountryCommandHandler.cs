using Application.Abstraction;
using Application.Features.Exceptions;

namespace Application.Features.Country.Commands.DeleteCountry;

public class DeleteCountryCommandHandler : ICommandHandler<DeleteCountryCommand,bool>
{
    private readonly ICountryRepository _countryRepository;

    public DeleteCountryCommandHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }
    
    public async Task<bool> HandleAsync(DeleteCountryCommand command)
    {
        var existingCountry = await _countryRepository.ExistsAsync(command.Id);
        if (!existingCountry)
        {
            throw new NotFoundException("Country not found");
        }
        await _countryRepository.DeleteAsync(command.Id);
        return true;
    }
}