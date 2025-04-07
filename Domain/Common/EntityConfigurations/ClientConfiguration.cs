using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Common.Entities;

namespace Domain.Common.EntityConfigurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("CLIENTS");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("ID");
        builder.Property(x => x.Name).HasColumnName("NAME").HasMaxLength(100).IsRequired();
        builder.Property(x => x.Surname).HasColumnName("SURNAME").HasMaxLength(100).IsRequired();
        builder.Property(x => x.Phone).HasColumnName("PHONE").HasMaxLength(20);
        builder.Property(x => x.Email).HasColumnName("EMAIL").HasMaxLength(100);
        builder.Property(x => x.Login).HasColumnName("LOGIN").HasMaxLength(100);
        builder.Property(x => x.Password).HasColumnName("PASSWORD").HasMaxLength(100);
    }
}