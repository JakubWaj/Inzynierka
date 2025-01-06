using Application.Features.Country;
using Application.Features.MovieCountry;
using Application.Features.Reviews;
using Application.Features.Roles;
using Domain.Common.Enums;
using Domain.Entities;

namespace Application.Features.Movies;

public record MovieDtoModel(Guid Id,string Title, string Description, Genre Genre, DateTime ReleaseDate, int BoxOffice, int Duration);

public record MovieDto(Guid Id,
    string Title,
    string Description,
    Genre Genre,
    DateTime ReleaseDate,
    int BoxOffice,
    int Duration,
    IEnumerable<ReviewDto> reviews,
    IEnumerable<RoleDto> Roles ,
    IEnumerable<MovieCountryDto> countries,
    string Image="",
    decimal? Score=default,
    int? NumberOfReviews=default);
    
public record MainPageMovieDto(Guid Id,
    string Title,
    string Description,
    Genre Genre,
    DateTime ReleaseDate,
    int BoxOffice,
    int Duration,
    IEnumerable<ReviewDto> reviews,
    IEnumerable<RoleDto> Roles ,
    IEnumerable<MovieCountryDto> countries,
    string Image="",
    decimal? Score=default,
    int? NumberOfReviews=default,
    bool? liked=false,
    bool? watchlater=false
    );
    
public record MainPageDto(
    IEnumerable<MainPageMovieDto> RecommendedMovies,
    IEnumerable<MainPageMovieDto> PopularAmongFriendsMovies
        );