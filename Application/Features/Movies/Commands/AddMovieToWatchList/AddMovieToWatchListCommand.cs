using Application.Abstraction;

namespace Application.Features.Movies.Commands.AddMovieToWatchList;

public class AddMovieToWatchListCommand : ICommand<bool>
{
        public Guid UserId { get; set; }
        public Guid MovieId { get; set; }
        public Guid Id { get; set; }
}