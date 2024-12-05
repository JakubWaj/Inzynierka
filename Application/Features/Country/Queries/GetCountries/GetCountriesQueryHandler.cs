using Application.Abstraction;

namespace Application.Features.Country.Queries.GetCountries;

public class GetCountriesQueryHandler: IQueryHandler<GetCountriesQuery, IEnumerable<CountryDto>>
{
    private readonly ICountryRepository _countryRepository;

    public GetCountriesQueryHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }
    
    public async Task<IEnumerable<CountryDto>> HandleAsync(GetCountriesQuery query)
    {
        var countries  = await _countryRepository.GetAllAsync();
        return countries.ToDto();
    }
}