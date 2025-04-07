using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Common.Entities;

namespace Domain.Common.EntityConfigurations;

public class ResTableLimitConfiguration : IEntityTypeConfiguration<ResTableLimit>
{
    public void Configure(EntityTypeBuilder<ResTableLimit> builder)
    {
        builder.ToTable("RES_TABLE_LIMITS");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("ID");
        builder.Property(x => x.Table_Type_Id).HasColumnName("TABLE_TYPE_ID");
        builder.Property(x => x.LimitCount).HasColumnName("LIMIT_COUNT");
        builder.Property(x => x.ResId).HasColumnName("RES_ID");

        builder.HasOne(x => x.TableType)
               .WithMany(x => x.TableLimits)
               .HasForeignKey(x => x.Table_Type_Id);

        builder.HasOne(x => x.Restaurant)
               .WithMany(x => x.TableLimits)
               .HasForeignKey(x => x.ResId);
    }
}