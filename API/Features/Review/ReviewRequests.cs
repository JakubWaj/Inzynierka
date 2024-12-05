namespace API.Features.Review;

public record ReviewRequests(int Rating,string Comment, Guid MovieId);