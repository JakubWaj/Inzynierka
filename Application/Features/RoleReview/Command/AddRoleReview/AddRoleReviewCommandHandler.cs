using Application.Abstraction;
using Application.Features.RoleReview.Exceptions;

namespace Application.Features.RoleReview.Command.AddRoleReview;

public class AddRoleReviewCommandHandler : ICommandHandler<AddRoleReviewCommand,bool>
{
    private readonly IRoleReviewRepository _roleReviewRepository;

    public AddRoleReviewCommandHandler(IRoleReviewRepository roleReviewRepository)
    {
        _roleReviewRepository = roleReviewRepository;
    }
    
    public async Task<bool> HandleAsync(AddRoleReviewCommand command)
    {
        var userRoleReviewExists =await _roleReviewRepository.ExistsFromUser(command.UserId, command.RoleId);
        if (userRoleReviewExists)
        {
            throw new RoleReviewAlreadyExists($"user {command.UserId} role {command.RoleId}");

        }
        var role = new Domain.Entities.RoleReview()
        {
            Id = command.Id,
            UserId = command.UserId,
            RoleId = command.RoleId,
            Rating = command.Rating,
            CreatedAt = DateTime.Now.ToUniversalTime()
        };
        await _roleReviewRepository.AddAsync(role);
        return true;
    }
}