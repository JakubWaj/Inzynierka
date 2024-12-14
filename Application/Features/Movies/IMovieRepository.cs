using Domain.Entities;

namespace Application.Features.Movies;

public interface IMovieRepository
{
    Task<Movie> GetAsync(Guid Id);
    Task<IEnumerable<Movie>> GetAllAsync();
    Task AddAsync(Movie movie);
    Task UpdateAsync(Movie movie);
    Task DeleteAsync(Guid Id);
    Task<bool> ExistsAsync(Guid Id);
    Task<bool> ExistsAsyncWithTheSameTitle(string Title);
    Task<IEnumerable<Movie>> GetByTitleAsync(string Title);
    Task<IEnumerable<Movie>> GetByGenreAsync(string Genre);
    Task<IEnumerable<Movie>> GetByReleaseYearAsync(int ReleaseDate);
    Task<IEnumerable<Movie>> GetByCountryAsync(Guid CountryId);
    
    Task AddFavoriteMovieAsync(Guid UserId, Guid MovieId, Guid Id);
    Task RemoveFavoriteMovieAsync(Guid UserId, Guid MovieId);
    Task<IEnumerable<Movie>> GetFavoriteMoviesAsync(Guid UserId);
    
    Task AddWatchLaterMovieAsync(Guid UserId, Guid MovieId, Guid Id);
    Task RemoveWatchLaterMovieAsync(Guid UserId, Guid MovieId);
    Task<IEnumerable<Movie>> GetWatchLaterMoviesAsync(Guid UserId);
    
}