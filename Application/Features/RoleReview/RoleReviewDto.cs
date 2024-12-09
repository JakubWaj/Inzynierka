using Domain.Common.Enums;
using Domain.Entities;

namespace Application.Features.RoleReview;

public record RoleReviewDto(int Rating,Guid RoleId,MovieProductionRole ProductionRole,string FirstName,string LastName);
public record RoleReviewsDto(double Rating,Guid RoleId,MovieProductionRole ProductionRole,string FirstName,string LastName);
