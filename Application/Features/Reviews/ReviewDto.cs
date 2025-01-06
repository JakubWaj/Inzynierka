using Application.Features.Movies;
using Application.Features.Users;
using Domain.Entities;

namespace Application.Features.Reviews;

public class ReviewDto
{
    public Guid Id { get; set; }
    public string Comment { get; set; }
    public int Rating { get; set; }
    public Guid MovieId { get; set; }
    public MovieDtoModel Movie { get; set; }
    public Guid UserId { get; set; }
    public UserDto User { get; set; }
    public DateTime CreatedAt { get; set; }
}