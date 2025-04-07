using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Common.Entities;

namespace Domain.Common.EntityConfigurations;

public class HallTableGuestConfiguration : IEntityTypeConfiguration<HallTableGuest>
{
    public void Configure(EntityTypeBuilder<HallTableGuest> builder)
    {
        builder.ToTable("HALL_TABLE_GUESTS");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("ID");
        builder.Property(x => x.Name).HasColumnName("NAME").HasMaxLength(100).IsRequired();
        builder.Property(x => x.ChairNumber).HasColumnName("CHAIR_NUMBER");
        builder.Property(x => x.Hall_Table_Id).HasColumnName("HALL_TABLE_ID");

        builder.HasOne(x => x.HallTable)
               .WithMany(x => x.Guests)
               .HasForeignKey(x => x.Hall_Table_Id);
    }
}