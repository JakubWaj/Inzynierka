using Application.Abstraction;

namespace Application.Features.Country.Queries.GetCountry;

public class GetCountryQuery : IQuery<CountryDto>
{
    public Guid Id { get; set; }
}