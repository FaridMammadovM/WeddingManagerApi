using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Common.Entities;

namespace Domain.Common.EntityConfigurations;

public class HallTableConfiguration : IEntityTypeConfiguration<HallTable>
{
    public void Configure(EntityTypeBuilder<HallTable> builder)
    {
        builder.ToTable("HALL_TABLES");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("ID");
        builder.Property(x => x.Name).HasColumnName("NAME").HasMaxLength(100).IsRequired();
        builder.Property(x => x.Table_Type_Id).HasColumnName("TABLE_TYPE_ID");
        builder.Property(x => x.WeddingId).HasColumnName("WEDDING_ID");

        builder.HasOne(x => x.TableType)
               .WithMany(x => x.HallTables)
               .HasForeignKey(x => x.Table_Type_Id);

        builder.HasOne(x => x.Wedding)
               .WithMany(x => x.HallTables)
               .HasForeignKey(x => x.WeddingId);
    }
}