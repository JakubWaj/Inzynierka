namespace Domain.Entities;

public class WatchLaterMovies
{
    public Guid Id { get; set; }
    public virtual Movie Movie { get; set; }
    public Guid MovieId { get; set; }
    public virtual User User { get; set; }
    public Guid UserId { get; set; }
}