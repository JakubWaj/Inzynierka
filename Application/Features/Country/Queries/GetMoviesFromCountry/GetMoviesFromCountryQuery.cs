using Application.Abstraction;
using Application.Features.Movies;

namespace Application.Features.Country.Queries.GetMoviesFromCountry;

public class GetMoviesFromCountryQuery : IQuery<IEnumerable<MovieDto>>
{
    public Guid Id { get; set; }
}