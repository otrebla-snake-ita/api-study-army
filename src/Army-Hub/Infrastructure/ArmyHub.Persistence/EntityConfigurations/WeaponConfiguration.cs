using ArmyHub.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyHub.Persistence.EntityConfigurations;

public sealed class WeaponConfiguration : IEntityTypeConfiguration<Weapon>
{
    public void Configure(EntityTypeBuilder<Weapon> builder)
    {
        builder.HasKey(w => w.Id)
            .HasName("PK_Weapon");

        builder.HasIndex(w => w.Id)
            .IsUnique()
            .HasDatabaseName("IX_Weapon_Id");

        builder.HasOne(w => w.Storage)
            .WithMany(s => s.Weapons)
            .HasForeignKey(w => w.StorageId)
            .HasConstraintName("FK_Weapon_Storage")
            .IsRequired();

        builder.HasOne(w => w.AmmunitionType)
            .WithMany(at => at.Weapons)
            .HasForeignKey(w => w.AmmunitionTypeId)
            .HasConstraintName("FK_Weapon_AmmunitionType")
            .IsRequired();

        builder.HasOne(w => w.WeaponType)
            .WithMany(wt => wt.Weapons)
            .HasForeignKey(w => w.WeaponTypeId)
            .HasConstraintName("FK_Weapon_WeaponType")
            .IsRequired();

        builder.Property(w => w.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.HasIndex(w => w.Name)
            .IsUnique()
            .HasDatabaseName("IX_Weapon_Name");

        builder.Property(w => w.Description)
            .HasMaxLength(250);

        builder.Property(w => w.Quantity)
            .IsRequired();

        builder.ToTable("Weapons");
    }
}
