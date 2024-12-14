namespace Domain.Entities;

public class FavoriteMovies
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid UserId { get; set; }
}