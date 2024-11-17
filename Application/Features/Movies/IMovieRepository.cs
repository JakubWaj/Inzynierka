using Domain.Entities;

namespace Application.Features.Movies;

public interface IMovieRepository
{
    Task AddAsync(Movie movie);
    Task UpdateAsync(Movie movie);
    Task DeleteAsync(Guid Id);
    Task<Movie> GetAsync(Guid Id);
    Task<bool> ExistsAsync(Guid Id);
    Task<bool> ExistsAsyncWithTheSameTitle(string Title);
}