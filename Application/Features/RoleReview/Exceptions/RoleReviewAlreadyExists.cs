using Application.Shared;

namespace Application.Features.RoleReview.Exceptions;

public class RoleReviewAlreadyExists : BaseException
{
    public RoleReviewAlreadyExists(string message) : base(message)
    {
    }
}