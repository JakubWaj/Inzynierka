using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(50);
        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(50);
        builder.Property(x => x.BirthDate)
            .HasColumnType("date")
            .IsRequired();
        builder.Property(x => x.Biography).IsRequired().HasMaxLength(500);
    }
}