using Domain.Common.Enums;

namespace API.Controllers;

public record MovieRequest
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Genre Genre { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int BoxOffice { get; set; }
    public int Duration { get; set; }
}