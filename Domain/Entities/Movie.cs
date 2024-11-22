using System.Collections;
using Domain.Common.Enums;

namespace Domain.Entities;

public class Movie
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Genre Genre { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int BoxOffice { get; set; }
    public int Duration { get; set; }
    public ICollection<MovieCountry> CountryOfMovie { get; set; }
    public ICollection<Role> Cast { get; set; }
    public ICollection<Review> Reviews { get; set; }
}