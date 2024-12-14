using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration;

public class FavoriteMoviesConfiguration : IEntityTypeConfiguration<FavoriteMovies>
{
    public void Configure(EntityTypeBuilder<FavoriteMovies> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.MovieId)
            .IsRequired();
        builder.Property(x => x.UserId)
            .IsRequired();
    }
}