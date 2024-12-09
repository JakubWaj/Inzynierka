namespace API.Features.RoleReview;

public record RoleReviewRequest(int Rating,string Comment, Guid RoleId);