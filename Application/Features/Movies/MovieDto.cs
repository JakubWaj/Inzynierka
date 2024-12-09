using Application.Features.Country;
using Application.Features.MovieCountry;
using Domain.Common.Enums;

namespace Application.Features.Movies;

public record MovieDto(Guid Id,string Title, string Description, Genre Genre, DateTime ReleaseDate, int BoxOffice, int Duration,IEnumerable<MovieCountryDto> countries,decimal? Score=default,int? NumberOfReviews=default);