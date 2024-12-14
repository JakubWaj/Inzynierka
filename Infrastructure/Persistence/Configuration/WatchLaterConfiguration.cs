using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration;

public class WatchLaterConfiguration : IEntityTypeConfiguration<WatchLaterMovies>
{
    public void Configure(EntityTypeBuilder<WatchLaterMovies> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.MovieId)
            .IsRequired();
        builder.Property(x => x.UserId)
            .IsRequired();
    }
}