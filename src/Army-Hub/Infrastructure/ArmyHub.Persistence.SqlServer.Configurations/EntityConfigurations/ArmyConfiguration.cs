using ArmyHub.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyHub.Persistence.SqlServer.Configurations.EntityConfigurations;

public sealed class ArmyConfiguration : IEntityTypeConfiguration<Army>
{
    public void Configure(EntityTypeBuilder<Army> builder)
    {
        builder.HasKey(a => a.Id)
            .HasName("PK_Army");

        builder.HasIndex(a => a.Id)
            .IsUnique()
            .HasDatabaseName("IX_Army_Id");

        builder.HasOne(a => a.Country)
            .WithMany(c => c.Armies)
            .HasForeignKey(a => a.CountryId)
            .HasConstraintName("FK_Army_Country")
            .IsRequired();

        builder.Property(a => a.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.HasIndex(a => a.Name)
            .IsUnique()
            .HasDatabaseName("IX_Army_Name");

        builder.ToTable("Armies");
    }
}
