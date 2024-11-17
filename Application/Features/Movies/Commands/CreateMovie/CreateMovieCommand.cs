using Application.Abstraction;
using Domain.Common.Enums;
using Domain.Entities;

namespace Application.Features.Movies.Commands.CreateMovie;

public class CreateMovieCommand : ICommand<bool>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Genre Genre { get; set; }
    public DateTime ReleaseDate { get; set; }
    public uint BoxOffice { get; set; }
    public uint Duration { get; set; }
}