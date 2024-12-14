using Application.Abstraction;

namespace Application.Features.Movies.Commands.AddMovieToFavorites;

public class AddMovieToFavoritesCommand : ICommand<bool>
{
    public Guid UserId { get; set; }
    public Guid MovieId { get; set; }
    public Guid Id { get; set; }
}