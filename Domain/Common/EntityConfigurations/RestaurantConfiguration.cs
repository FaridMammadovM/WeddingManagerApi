using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Common.Entities;

namespace Domain.Common.EntityConfigurations;

public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
{
    public void Configure(EntityTypeBuilder<Restaurant> builder)
    {
        builder.ToTable("RESTAURANTS");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("ID");
        builder.Property(x => x.Name).HasColumnName("NAME").HasMaxLength(100).IsRequired();
        builder.Property(x => x.Phone).HasColumnName("PHONE").HasMaxLength(20);
        builder.Property(x => x.Address).HasColumnName("ADDRESS").HasMaxLength(255);
        builder.Property(x => x.Location).HasColumnName("LOCATION").HasMaxLength(255);
    }
}