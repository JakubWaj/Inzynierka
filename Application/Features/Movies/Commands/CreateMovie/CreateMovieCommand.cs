using Application.Abstraction;
using Domain.Common.Enums;
using Domain.Entities;

namespace Application.Features.Movies.Commands.CreateMovie;

public class CreateMovieCommand : ICommand<bool>
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Genre Genre { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int BoxOffice { get; set; }
    public int Duration { get; set; }
    public string[] Countries { get; set; }
}