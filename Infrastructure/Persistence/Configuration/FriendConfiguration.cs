using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration;

public class FriendConfiguration : IEntityTypeConfiguration<UserFriends>
{
    public void Configure(EntityTypeBuilder<UserFriends> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.UserId)
            .IsRequired();
        builder.Property(x => x.FriendId)
            .IsRequired();
        builder.Property(x => x.Status)
            .IsRequired();
        
    }
}