using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration;

public class RoleReviewConfiguration : IEntityTypeConfiguration<RoleReview>
{
    public void Configure(EntityTypeBuilder<RoleReview> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Rating).IsRequired();
        builder.HasOne(x => x.Role).WithMany(x => x.Reviews).HasForeignKey(x => x.RoleId);
        builder.HasOne(x => x.User).WithMany(x=>x.RoleReviews).HasForeignKey(x => x.UserId);
    }
}