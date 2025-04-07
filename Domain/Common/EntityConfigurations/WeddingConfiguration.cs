using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Common.Entities;

namespace Domain.Common.EntityConfigurations;

public class WeddingConfiguration : IEntityTypeConfiguration<Wedding>
{
    public void Configure(EntityTypeBuilder<Wedding> builder)
    {
        builder.ToTable("WEDDINGS");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("ID");
        builder.Property(x => x.ClientId).HasColumnName("CLIENT_ID");
        builder.Property(x => x.Date).HasColumnName("DATE").IsRequired();

        builder.HasOne(x => x.Client)
               .WithMany(x => x.Weddings)
               .HasForeignKey(x => x.ClientId);
    }
}