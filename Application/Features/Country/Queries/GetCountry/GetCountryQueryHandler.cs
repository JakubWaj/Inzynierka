using Application.Abstraction;
using Application.Features.Exceptions;

namespace Application.Features.Country.Queries.GetCountry;

public class GetCountryQueryHandler : IQueryHandler<GetCountryQuery,CountryDto>
{
    private readonly ICountryRepository _countryRepository;

    public GetCountryQueryHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }
    
    public async Task<CountryDto> HandleAsync(GetCountryQuery query)
    {
        var exists = await _countryRepository.ExistsAsync(query.Id);
        if (!exists)
        {
            throw new NotFoundException("Country not found");
        }
        var country = await _countryRepository.GetAsync(query.Id);
        return country.ToDto();
    }
}