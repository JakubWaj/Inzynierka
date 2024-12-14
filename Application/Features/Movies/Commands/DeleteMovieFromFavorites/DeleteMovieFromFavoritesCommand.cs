using System.Windows.Input;
using Application.Abstraction;

namespace Application.Features.Movies.Commands.DeleteMovieFromFavorites;

public class DeleteMovieFromFavoritesCommand : ICommand<bool>
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
}