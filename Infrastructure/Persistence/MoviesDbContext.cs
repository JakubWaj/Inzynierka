using Domain.Common.Enums;
using Domain.Entities;
using Infrastructure.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class MoviesDbContext : DbContext
{
    
    private readonly IPasswordHasher<User> _passwordHasher;
    public MoviesDbContext(DbContextOptions<MoviesDbContext> options, IPasswordHasher<User> passwordHasher) : base(options)
    {
        _passwordHasher = passwordHasher;
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
    // Seed Countries
    var countries = new[]
    {
        new Country { Id = Guid.NewGuid(), Name = "United States" },
        new Country { Id = Guid.NewGuid(), Name = "Poland" },
        new Country { Id = Guid.NewGuid(), Name = "Japan" },
        new Country { Id = Guid.NewGuid(), Name = "United Kingdom" },
        new Country { Id = Guid.NewGuid(), Name = "Canada" }
    };
    modelBuilder.Entity<Country>().HasData(countries);

    // Seed Movies
    var movies = new[]
    {
        new Movie
        {
            Id = Guid.NewGuid(),
            Title = "Inception",
            Description = "A thief who steals corporate secrets through dream-sharing technology is tasked with planting an idea into a target's subconscious.",
            Genre = Genre.SciFi,
            ReleaseDate = new DateTime(2010, 7, 16),
            BoxOffice = 829895144,
            Duration = 148
        },
        new Movie
        {
            Id = Guid.NewGuid(),
            Title = "Your Name",
            Description = "Two teenagers share a profound connection after discovering they are swapping bodies.",
            Genre = Genre.Anime,
            ReleaseDate = new DateTime(2016, 8, 26),
            BoxOffice = 361000000,
            Duration = 106
        },
        new Movie
        {
            Id = Guid.NewGuid(),
            Title = "The Matrix",
            Description = "A hacker discovers the shocking truth about his world and his role in the fight to save humanity.",
            Genre = Genre.SciFi,
            ReleaseDate = new DateTime(1999, 3, 31),
            BoxOffice = 466000000,
            Duration = 136
        },
        new Movie
        {
            Id = Guid.NewGuid(),
            Title = "Interstellar",
            Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
            Genre = Genre.SciFi,
            ReleaseDate = new DateTime(2014, 11, 7),
            BoxOffice = 701729206,
            Duration = 169
        },
        new Movie
        {
            Id = Guid.NewGuid(),
            Title = "Spirited Away",
            Description = "A young girl becomes trapped in a mysterious world of spirits and must find her way home.",
            Genre = Genre.Anime,
            ReleaseDate = new DateTime(2001, 7, 20),
            BoxOffice = 395800000,
            Duration = 125
        }
    };
    modelBuilder.Entity<Movie>().HasData(movies);

    // Seed Users
    var users = new[]
    {
        
        new User { Id = Guid.NewGuid(), Login = "user1", Password = _passwordHasher.HashPassword(null,"string"), Email = "user1@example.com" },
        new User { Id = Guid.NewGuid(), Login = "user2", Password = _passwordHasher.HashPassword(null,"string"), Email = "user2@example.com" },
        new User { Id = Guid.NewGuid(), Login = "user3", Password = _passwordHasher.HashPassword(null,"string"), Email = "user3@example.com" },
        new User { Id = Guid.NewGuid(), Login = "user4", Password = _passwordHasher.HashPassword(null,"string"), Email = "user4@example.com" },
        new User { Id = Guid.NewGuid(), Login = "user5", Password = _passwordHasher.HashPassword(null,"string"), Email = "user5@example.com" }
    };
    modelBuilder.Entity<User>().HasData(users);

    // Seed Reviews
    var reviews = new[]
    {
        new Review
        {
            Id = Guid.NewGuid(),
            Comment = "Amazing movie with a mind-blowing plot!",
            Rating = 9,
            MovieId = movies[0].Id,
            UserId = users[0].Id
        },
        new Review
        {
            Id = Guid.NewGuid(),
            Comment = "Beautifully animated and emotionally resonant.",
            Rating = 10,
            MovieId = movies[1].Id,
            UserId = users[1].Id
        },
        new Review
        {
            Id = Guid.NewGuid(),
            Comment = "A groundbreaking film with iconic visuals.",
            Rating = 10,
            MovieId = movies[2].Id,
            UserId = users[2].Id
        },
        new Review
        {
            Id = Guid.NewGuid(),
            Comment = "A mesmerizing journey through space and time.",
            Rating = 9,
            MovieId = movies[3].Id,
            UserId = users[3].Id
        },
        new Review
        {
            Id = Guid.NewGuid(),
            Comment = "A masterpiece of animation and storytelling.",
            Rating = 10,
            MovieId = movies[4].Id,
            UserId = users[4].Id
        }
    };
    modelBuilder.Entity<Review>().HasData(reviews);

    // Seed Persons and Roles
    var persons = new[]
    {
        new Person
        {
            Id = Guid.NewGuid(),
            FirstName = "Leonardo",
            LastName = "DiCaprio",
            BirthDate = new DateTime(1974, 11, 11),
            Biography = "An American actor and film producer."
        },
        new Person
        {
            Id = Guid.NewGuid(),
            FirstName = "Makoto",
            LastName = "Shinkai",
            BirthDate = new DateTime(1973, 2, 9),
            Biography = "A Japanese animator, filmmaker, and manga artist."
        },
        new Person
        {
            Id = Guid.NewGuid(),
            FirstName = "Keanu",
            LastName = "Reeves",
            BirthDate = new DateTime(1964, 9, 2),
            Biography = "An actor known for his roles in The Matrix and John Wick."
        },
        new Person
        {
            Id = Guid.NewGuid(),
            FirstName = "Christopher",
            LastName = "Nolan",
            BirthDate = new DateTime(1970, 7, 30),
            Biography = "A British-American film director, producer, and screenwriter."
        },
        new Person
        {
            Id = Guid.NewGuid(),
            FirstName = "Hayao",
            LastName = "Miyazaki",
            BirthDate = new DateTime(1941, 1, 5),
            Biography = "A legendary Japanese animator and filmmaker."
        }
    };
    modelBuilder.Entity<Person>().HasData(persons);

    var roles = new[]
    {
        new Role
        {
            Id = Guid.NewGuid(),
            PersonId = persons[0].Id,
            MovieId = movies[0].Id,
            MovieProductionRole = MovieProductionRole.Actor,
            Character = "Dom Cobb"
        },
        new Role
        {
            Id = Guid.NewGuid(),
            PersonId = persons[1].Id,
            MovieId = movies[1].Id,
            MovieProductionRole = MovieProductionRole.Director
        },
        new Role
        {
            Id = Guid.NewGuid(),
            PersonId = persons[2].Id,
            MovieId = movies[2].Id,
            MovieProductionRole = MovieProductionRole.Actor,
            Character = "Neo"
        },
        new Role
        {
            Id = Guid.NewGuid(),
            PersonId = persons[3].Id,
            MovieId = movies[3].Id,
            MovieProductionRole = MovieProductionRole.Director
        },
        new Role
        {
            Id = Guid.NewGuid(),
            PersonId = persons[4].Id,
            MovieId = movies[4].Id,
            MovieProductionRole = MovieProductionRole.Director
        }
    };
    modelBuilder.Entity<Role>().HasData(roles);

    // Seed MovieCountry
    var movieCountries = new[]
    {
        new MovieCountry { MovieId = movies[0].Id, CountryId = countries[0].Id },
        new MovieCountry { MovieId = movies[1].Id, CountryId = countries[2].Id },
        new MovieCountry { MovieId = movies[2].Id, CountryId = countries[0].Id },
        new MovieCountry { MovieId = movies[3].Id, CountryId = countries[1].Id },
        new MovieCountry { MovieId = movies[4].Id, CountryId = countries[2].Id }
    };
    modelBuilder.Entity<MovieCountry>().HasData(movieCountries);
    }
}