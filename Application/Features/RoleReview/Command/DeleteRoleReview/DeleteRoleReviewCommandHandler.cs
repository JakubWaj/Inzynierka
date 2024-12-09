using Application.Abstraction;
using Application.Features.Exceptions;
using Application.Features.Reviews.Exceptions;

namespace Application.Features.RoleReview.Command.DeleteRoleReview;

public class DeleteRoleReviewCommandHandler : ICommandHandler<DeleteRoleReviewCommand,bool>
{
    private readonly IRoleReviewRepository _roleReviewRepository;

    public DeleteRoleReviewCommandHandler(IRoleReviewRepository roleReviewRepository)
    {
        _roleReviewRepository = roleReviewRepository;
    }
    
    public async Task<bool> HandleAsync(DeleteRoleReviewCommand command)
    {
        var roleReviewExistsAsync =await _roleReviewRepository.ExistsAsync(command.Id);
        if (!roleReviewExistsAsync)
        {
            throw new NotFoundException("Role review not found");
        }

        var role = await _roleReviewRepository.GetAsync(command.Id);
        if (role.UserId!=command.UserId)
        {
            throw new ForbiddenException("You cannot delete that review");
        }

        await _roleReviewRepository.DeleteAsync(command.Id);
        return true;
    }
}