using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration;

public class MovieCountryConfiguration : IEntityTypeConfiguration<MovieCountry>
{
    public void Configure(EntityTypeBuilder<MovieCountry> builder)
    {
        builder.HasKey(x=>new {x.MovieId,x.CountryId});
        builder.HasOne(x=>x.Movie)
            .WithMany(x=>x.CountryOfMovie)
            .HasForeignKey(x=>x.MovieId);
        builder.HasOne(x=>x.Country)
            .WithMany(x=>x.Productions)
            .HasForeignKey(x=>x.CountryId);
    }
}