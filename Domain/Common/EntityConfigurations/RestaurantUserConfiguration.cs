using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Common.Entities;

namespace Domain.Common.EntityConfigurations;

public class RestaurantUserConfiguration : IEntityTypeConfiguration<RestaurantUser>
{
    public void Configure(EntityTypeBuilder<RestaurantUser> builder)
    {
        builder.ToTable("RESTAURANT_USERS");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("ID");
        builder.Property(x => x.ResId).HasColumnName("RES_ID");
        builder.Property(x => x.Name).HasColumnName("NAME").HasMaxLength(100).IsRequired();
        builder.Property(x => x.Login).HasColumnName("LOGIN").HasMaxLength(100).IsRequired();
        builder.Property(x => x.Password).HasColumnName("PASSWORD").HasMaxLength(100).IsRequired();

        builder.HasOne(x => x.Restaurant)
               .WithMany(x => x.Users)
               .HasForeignKey(x => x.ResId);
    }
}