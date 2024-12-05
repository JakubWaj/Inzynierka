﻿using Application.Abstraction;
using Application.Features.MovieCountry;

namespace Application.Features.Movies.Queries.GetMovieByCountry;

public class GetMovieByCountryQueryHandler : IQueryHandler<GetMovieByCountryQuery,IEnumerable<MovieDto>>
{
    private readonly IMovieRepository _repository;

    public GetMovieByCountryQueryHandler(IMovieRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<IEnumerable<MovieDto>> HandleAsync(GetMovieByCountryQuery query)
    {
        var movies = await _repository.GetByCountryAsync(query.CountryId);
        return movies.Select(x => new MovieDto(x.Id,x.Title , x.Description, x.Genre, x.ReleaseDate, x.BoxOffice, x.Duration, x.CountryOfMovie.CountriesToDto()));
    }
}