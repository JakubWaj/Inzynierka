using Domain.Common.Enums;
using Domain.Entities;

namespace Application.Features.Roles;

public class RoleDto
{
    public Guid Id { get; set; }
    public Guid PersonId { get; set; }
    public Guid MovieId { get; set; }
    public MovieProductionRole MovieProductionRole { get; set; }
    public string? Character { get; set; }

    public double Score { get; set; }
    public int NumberOfReviews { get; set; }
    /*public ICollection<RoleReview> Reviews { get; set; }*/
}