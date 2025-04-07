using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Common.Entities;

namespace Domain.Common.EntityConfigurations;

public class RestaurantHallConfiguration : IEntityTypeConfiguration<RestaurantHall>
{
    public void Configure(EntityTypeBuilder<RestaurantHall> builder)
    {
        builder.ToTable("RESTAURANT_HALLS");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("ID");
        builder.Property(x => x.Name).HasColumnName("NAME").HasMaxLength(100).IsRequired();
        builder.Property(x => x.MinCount).HasColumnName("MIN_COUNT");
        builder.Property(x => x.MaxCount).HasColumnName("MAX_COUNT");
        builder.Property(x => x.ResId).HasColumnName("RES_ID");
        builder.Property(x => x.IsActive).HasColumnName("IS_ACTIVE");

        builder.HasOne(x => x.Restaurant)
               .WithMany(x => x.Halls)
               .HasForeignKey(x => x.ResId);
    }
}