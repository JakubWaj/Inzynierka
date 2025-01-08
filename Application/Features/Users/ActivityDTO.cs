using System.Collections;
using Application.Features.Movies;
using Domain.Entities;

namespace Application.Features.Users;

public record ActivityDTO(
    Guid Id,
    Guid UserId,
    string UserName,
     IEnumerable<MovieDto> FavoriteMovies,
    IEnumerable<MovieDto> WatchedMovies,
    IEnumerable<MovieDto> WatchLaterMovies
    );