using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Person)
            .WithMany(x => x.Roles)
            .HasForeignKey(x => x.PersonId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x => x.Movie)
            .WithMany(x => x.Cast)
            .HasForeignKey(x => x.MovieId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.Property(x => x.MovieProductionRole)
            .IsRequired();
        builder.Property(x => x.Character)
            .HasMaxLength(50);
    }
}