using ArmyHub.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyHub.Persistence.SqlServer.Configurations.EntityConfigurations;

public sealed class AmmunitionConfiguration : IEntityTypeConfiguration<Ammunition>
{
    public void Configure(EntityTypeBuilder<Ammunition> builder)
    {
        builder.HasKey(a => a.Id)
            .HasName("PK_Ammunition");

        builder.HasIndex(a => a.Id)
            .IsUnique()
            .HasDatabaseName("IX_Ammunition_Id");

        builder.HasOne(a => a.AmmunitionType)
            .WithMany(at => at.Ammunitions)
            .HasForeignKey(a => a.AmmunitionTypeId)
            .HasConstraintName("FK_Ammunition_AmmunitionType")
            .IsRequired();

        builder.Property(a => a.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.HasIndex(a => a.Name)
            .IsUnique()
            .HasDatabaseName("IX_Ammunition_Name");

        builder.Property(a => a.Description)
            .HasMaxLength(200);

        builder.Property(a => a.Quantity)
            .IsRequired();

        builder.ToTable("Ammunitions");
    }
}
