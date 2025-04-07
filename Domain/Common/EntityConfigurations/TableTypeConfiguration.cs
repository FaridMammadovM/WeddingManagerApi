using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Common.Entities;

namespace Domain.Common.EntityConfigurations;

public class TableTypeConfiguration : IEntityTypeConfiguration<TableType>
{
    public void Configure(EntityTypeBuilder<TableType> builder)
    {
        builder.ToTable("TABLE_TYPES");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("ID");
        builder.Property(x => x.Name).HasColumnName("NAME").HasMaxLength(50).IsRequired();
        builder.Property(x => x.Count).HasColumnName("COUNT");
    }
}