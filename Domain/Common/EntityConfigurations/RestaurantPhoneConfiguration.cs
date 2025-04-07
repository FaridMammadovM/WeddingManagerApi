using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Common.Entities;

namespace Domain.Common.EntityConfigurations;

public class RestaurantPhoneConfiguration : IEntityTypeConfiguration<RestaurantPhone>
{
    public void Configure(EntityTypeBuilder<RestaurantPhone> builder)
    {
        builder.ToTable("RESTAURANT_PHONES");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("ID");
        builder.Property(x => x.Phone).HasColumnName("PHONE").HasMaxLength(20).IsRequired();
        builder.Property(x => x.ResId).HasColumnName("RES_ID");

        builder.HasOne(x => x.Restaurant)
               .WithMany(x => x.Phones)
               .HasForeignKey(x => x.ResId);
    }
}