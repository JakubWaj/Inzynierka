﻿using Application.Features.MovieCountry;
using Application.Features.Movies;
using Application.Features.Reviews;
using Application.Features.Roles;

namespace Application.Features;

public static class MovieMapper
{
    public static MovieDto ToDto(this Domain.Entities.Movie movie)
    {
        return new MovieDto(movie.Id, movie.Title , movie.Description, movie.Genre, movie.ReleaseDate, movie.BoxOffice, movie.Duration,movie.Reviews.ToDto(), movie.Cast.ToDto(),movie.CountryOfMovie.CountriesToDto(),CalculateScore(movie),movie.Reviews.Count());
    }
    
    public static IEnumerable<MovieDto> ToDto(this IEnumerable<Domain.Entities.Movie> movies)
    {
        return movies.Select(x => x.ToDto());
    }
    private static decimal CalculateScore(this Domain.Entities.Movie movie)
    {
        var numberOfReviews = movie.Reviews.Count();
        
        if(numberOfReviews == 0)
        {
            return 0;
        }
        decimal score = movie.Reviews.Sum(x => x.Rating);
        score /= numberOfReviews;
        return score;
    }
    
}
