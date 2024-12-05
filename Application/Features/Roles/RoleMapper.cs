using Application.Features.Reviews;
using Domain.Entities;

namespace Application.Features.Roles;

public static class RoleMapper
{
    public static RoleDto ToDto(this Role review)
    {
        return new RoleDto()
        {
            Id = review.Id,
            PersonId = review.PersonId,
            MovieId = review.MovieId,
            MovieProductionRole = review.MovieProductionRole,
            Character = review.Character
        };
    }
    public static IEnumerable<RoleDto> ToDto(this IEnumerable<Role> roles)
    {
        return roles.Select(x => x.ToDto());
    }
}