using Application.Abstraction;
using Domain.Entities;

namespace Application.Features.Movies.Commands.AddFewMovies;

public class AddFewMoviesCommand : ICommand<bool>
{
    public List<Movie> MoviesList { get; set; }
    
}