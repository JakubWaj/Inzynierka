namespace Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<RoleReview> RoleReviews { get; set; }
    public ICollection<Movie> FavoriteMovies { get; set; }
    public ICollection<Movie> WatchedMovies { get; set; }
}