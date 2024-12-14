using System.Windows.Input;
using Application.Abstraction;

namespace Application.Features.Movies.Commands.DeleteMoviesFromWatchlist;

public class DeleteMoviesFromWatchlistCommand : ICommand<bool>
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
}