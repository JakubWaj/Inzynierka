namespace Domain.Entities;

public class MovieCountry
{
    public Guid CountryId { get; set; }
    public virtual Country Country { get; set; }
    public Guid MovieId { get; set; }
    public virtual Movie Movie { get; set; }
}