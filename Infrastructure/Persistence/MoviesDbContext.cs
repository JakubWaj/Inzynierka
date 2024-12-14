using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class MoviesDbContext : DbContext
{
    public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; }
    public DbSet<MovieCountry> MovieCountries { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Person> People  { get; set; }
    public DbSet<Review> Reviews  { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<RoleReview> RoleReviews { get; set; }
    public DbSet<FavoriteMovies> FavoriteMovies { get; set; }
    public DbSet<WatchLaterMovies> WatchLaterMovies { get; set; }
    public DbSet<UserFriends> UserFriends { get; set; }
    
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MoviesDbContext).Assembly);
    }
}