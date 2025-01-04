using Application.Features.Movies;
using Domain.Common.Enums;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Features.Movies;

public class MovieRepository : IMovieRepository
{
    private readonly MoviesDbContext _context;

    public MovieRepository(MoviesDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Movie>> GetAllAsync()
    {
        return await _context.Movies
            .Include(x=>x.Cast)
            .ThenInclude(x=>x.Person)
            .Include(x=>x.Cast)
            .ThenInclude(x=>x.Reviews)
            .Include(x=>x.Reviews)
            .ThenInclude(x=>x.User)
            .Include(x=>x.CountryOfMovie)
            .ThenInclude(x=>x.Country)
            .ToListAsync();
    }

    public async Task AddAsync(Movie movie)
    {
        await _context.Movies.AddAsync(movie);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Movie movie)
    {
         _context.Movies.Update(movie);
         await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid Id)
    {
        var movie = await _context.Movies.SingleOrDefaultAsync(x=>x.Id==Id);
        _context.Movies.Remove(movie);
        await _context.SaveChangesAsync();
    }

    public async Task<Movie> GetAsync(Guid Id)
    {
        return await _context.Movies
            .Include(x=>x.Cast)
            .ThenInclude(x=>x.Person)
            .Include(x=>x.Cast)
            .ThenInclude(x=>x.Reviews)
            .Include(x=>x.Reviews)
            .ThenInclude(x=>x.User)
            .Include(x=>x.CountryOfMovie)
            .ThenInclude(x=>x.Country)
            .SingleOrDefaultAsync(x=>x.Id==Id);
    }

    public async Task<bool> ExistsAsync(Guid Id)
    {
        return await _context.Movies
            .AnyAsync(x=>x.Id==Id);
    }

    public Task<bool> ExistsAsyncWithTheSameTitle(string Title)
    {
        return _context.Movies
            .AnyAsync(x=>x.Title==Title);
    }

    public async Task<IEnumerable<Movie>> GetByTitleAsync(string Title)
    {
        return await _context.Movies
            .Include(x=>x.Cast)
            .ThenInclude(x=>x.Person)
            .Include(x=>x.Cast)
            .ThenInclude(x=>x.Reviews)
            .Include(x=>x.Reviews)
            .ThenInclude(x=>x.User)
            .Include(x=>x.CountryOfMovie)
            .ThenInclude(x=>x.Country)
            .Where(x=>x.Title.Contains(Title))
            .ToListAsync();
    }

    public async Task<IEnumerable<Movie>> GetByGenreAsync(string Genre)
    {
        if (!Enum.TryParse<Genre>(Genre, out var parsedGenre))
        {
            throw new ArgumentException($"Invalid genre: {Genre}");
        }

        return await _context.Movies
            .Include(x=>x.Cast)
            .ThenInclude(x=>x.Person)
            .Include(x=>x.Cast)
            .ThenInclude(x=>x.Reviews)
            .Include(x=>x.Reviews)
            .ThenInclude(x=>x.User)
            .Include(x=>x.CountryOfMovie)
            .ThenInclude(x=>x.Country)
            .Where(x => x.Genre == parsedGenre)
            .ToListAsync();
    }

    public async Task<IEnumerable<Movie>> GetByReleaseYearAsync(int ReleaseDate)
    {
        return await _context.Movies
            .Include(x=>x.Cast)
            .ThenInclude(x=>x.Person)
            .Include(x=>x.Cast)
            .ThenInclude(x=>x.Reviews)
            .Include(x=>x.Reviews)
            .ThenInclude(x=>x.User)
            .Include(x=>x.CountryOfMovie)
            .ThenInclude(x=>x.Country)
            .Where(x=>x.ReleaseDate.Year==ReleaseDate)
            .ToListAsync();
    }

    public async Task<IEnumerable<Movie>> GetByCountryAsync(Guid CountryId)
    {
        return await _context.Movies
            .Include(x=>x.Cast)
            .ThenInclude(x=>x.Person)
            .Include(x=>x.Cast)
            .ThenInclude(x=>x.Reviews)
            .Include(x=>x.Reviews)
            .ThenInclude(x=>x.User)
            .Include(x=>x.CountryOfMovie)
            .ThenInclude(x=>x.Country)
            .Where(x=>x.CountryOfMovie
                .Any(x=>x.CountryId==CountryId))
            .ToListAsync();
    }

    public async Task AddFavoriteMovieAsync(Guid UserId, Guid MovieId, Guid Id)
    {
        var movieFav = new FavoriteMovies()
        {
            UserId = UserId,
            MovieId = MovieId,
            Id = Id
        };
        await _context.FavoriteMovies.AddAsync(movieFav);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveFavoriteMovieAsync(Guid UserId, Guid MovieId)
    {
        var movieFav = await _context.FavoriteMovies.SingleOrDefaultAsync(x=>x.UserId==UserId && x.MovieId==MovieId);
        _context.FavoriteMovies.Remove(movieFav);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Movie>> GetFavoriteMoviesAsync(Guid UserId)
    {
        var usersMovies = await _context.FavoriteMovies
            .Where(x=>x.UserId==UserId)
            .Select(x=>x.MovieId)
            .ToListAsync();
        //get movies where id is in usersMovies
        return await _context.Movies
            .Include(x=>x.Cast)
            .ThenInclude(x=>x.Person)
            .Include(x=>x.Cast)
            .ThenInclude(x=>x.Reviews)
            .Include(x=>x.Reviews).ThenInclude(x=>x.User)
            .Include(x=>x.CountryOfMovie)
            .ThenInclude(x=>x.Country)
            .Where(x=>usersMovies.Contains(x.Id))
            .ToListAsync();
    }

    public async Task AddWatchLaterMovieAsync(Guid UserId, Guid MovieId, Guid Id)
    {
        var movieWatchLater = new WatchLaterMovies()
        {
            UserId = UserId,
            MovieId = MovieId,
            Id = Id
        };
        await _context.WatchLaterMovies.AddAsync(movieWatchLater);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveWatchLaterMovieAsync(Guid UserId, Guid MovieId)
    {
        var x = await _context.WatchLaterMovies.SingleOrDefaultAsync(x=>x.UserId==UserId && x.MovieId==MovieId);
        _context.WatchLaterMovies.Remove(x);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Movie>> GetWatchLaterMoviesAsync(Guid UserId)
    {
        var usersMovies = await _context.WatchLaterMovies
            .Where(x=>x.UserId==UserId)
            .Select(x=>x.MovieId)
            .ToListAsync();
        //get movies where id is in usersMovies
        return await _context.Movies
            .Include(x=>x.Cast)
            .ThenInclude(x=>x.Person)
            .Include(x=>x.Cast)
            .ThenInclude(x=>x.Reviews)
            .Include(x=>x.Reviews)
            .ThenInclude(x=>x.User)
            .Include(x=>x.CountryOfMovie)
            .ThenInclude(x=>x.Country)
            .Where(x=>usersMovies.Contains(x.Id))
            .ToListAsync();
    }
}