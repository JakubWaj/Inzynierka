using Application.Abstraction;
using Domain.Common.Enums;

namespace Application.Features.Movies.Commands.UpdateMovie;

public class UpdateMovieCommand : ICommand<bool>
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Genre Genre { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int BoxOffice { get; set; }
    public int Duration { get; set; }
}