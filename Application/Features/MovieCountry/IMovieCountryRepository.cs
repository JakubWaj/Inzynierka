namespace Application.Features.MovieCountry;

public interface IMovieCountryRepository
{
    Task<Domain.Entities.MovieCountry> GetAsync(Guid Id);
    Task<IEnumerable<Domain.Entities.MovieCountry>> GetAllAsync();
    Task<IEnumerable<Domain.Entities.MovieCountry>> GetAllMoviesFromCountry();
    Task<IEnumerable<Domain.Entities.MovieCountry>> GetAllCountriesForMovie();
    
    Task AddAsync(Domain.Entities.MovieCountry movieCountry);
    Task UpdateAsync(Domain.Entities.MovieCountry movieCountry);
    Task DeleteAsync(Guid Id);
    Task<bool> ExistsAsync(Guid Id);
}