using Application.Abstraction;

namespace Application.Features.Movies.Commands.DeleteMovie;

public class DeleteMovieCommand : ICommand<bool>
{
    public Guid Id { get; set; }
}