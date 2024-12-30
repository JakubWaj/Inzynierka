using Application.Features.MovieCountry;
using Application.Features.Movies;
using Application.Features.People;
using Application.Features.Reviews;
using Domain.Common.Enums;
using Domain.Entities;

namespace Application.Features.Roles;

public class RoleDto
{
    public Guid Id { get; set; }
    public Guid PersonId { get; set; }
    public RolePersonDto Person { get; set; }
    public RoleMovieDto Movie { get; set; }
    public Guid MovieId { get; set; }
    public MovieProductionRole MovieProductionRole { get; set; }
    public string? Character { get; set; }

    public double Score { get; set; }
    public int NumberOfReviews { get; set; }
    
    /*public ICollection<RoleReview> Reviews { get; set; }*/
}

public record RoleMovieDto(Guid Id,string Title, string Description, Genre Genre, DateTime ReleaseDate, int BoxOffice, int Duration);
public record RolePersonDto(Guid Id,string FirstName, string LastName, DateTime DateOfBirth, string Biography, string? PictureUrl);