using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(50);
        builder.Property(x => x.Password)
            .IsRequired()
            .HasMaxLength(250);
        builder.Property(x => x.Login)
            .IsRequired()
            .HasMaxLength(50);
    }
}