using Application.Abstraction;
using Application.Features.Exceptions;
using Application.Features.Reviews.Exceptions;
using Application.Features.RoleReview.Exceptions;

namespace Application.Features.RoleReview.Command.UpdateRoleReview;

public class UpdateRoleReviewCommandHandler : ICommandHandler<UpdateRoleReviewCommand,bool>
{
    private readonly IRoleReviewRepository _roleReviewRepository;

    public UpdateRoleReviewCommandHandler(IRoleReviewRepository roleReviewRepository)
    {
        _roleReviewRepository = roleReviewRepository;
    }
    
    public async Task<bool> HandleAsync(UpdateRoleReviewCommand command)
    {
        var userRoleReviewExists =await _roleReviewRepository.ExistsFromUser(command.UserId, command.RoleId);
        if (!userRoleReviewExists)
        {
            throw new NotFoundException($"user {command.UserId} role {command.RoleId}");

        }
        var oldRole = await _roleReviewRepository.GetAsync(command.Id);
        if (oldRole.UserId!=command.UserId)
        {
            throw new ForbiddenException("You cannot delete that review");
        }
        oldRole.Rating = command.Rating;
        await _roleReviewRepository.AddAsync(oldRole);
        return true;
    }
}