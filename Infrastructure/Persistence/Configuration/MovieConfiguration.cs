using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration;

public class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.HasKey(x=>x.Id);
        builder.Property(x => x.Title)
            .HasMaxLength(200);
        builder.Property(x => x.Description)
            .HasMaxLength(2000);
        builder.Property(x => x.ReleaseDate)
            .HasColumnType("date");
    }
}