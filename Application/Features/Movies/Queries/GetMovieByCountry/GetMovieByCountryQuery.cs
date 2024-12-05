using Application.Abstraction;

namespace Application.Features.Movies.Queries.GetMovieByCountry;

public class GetMovieByCountryQuery : IQuery<IEnumerable<MovieDto>>
{
    public Guid CountryId { get; set; }
}