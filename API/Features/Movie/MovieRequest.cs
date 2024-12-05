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

public record SearchByTitleRequest
{
    public string Title { get; set; }
}

public record SearchByGenreRequest
{
    public string Genre { get; set; }
}

public record SearchByReleaseYearRequest
{
    public int ReleaseYear { get; set; }
}