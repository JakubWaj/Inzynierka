using Domain.Entities;

namespace Application.Features.Country;

public class CountryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<Domain.Entities.MovieCountry> Productions { get; set; }
}