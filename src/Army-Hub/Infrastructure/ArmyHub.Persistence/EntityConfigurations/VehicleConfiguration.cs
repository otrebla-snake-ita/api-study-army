using ArmyHub.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyHub.Persistence.EntityConfigurations;

public sealed class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        builder.HasKey(v => v.Id)
            .HasName("PK_Vehicle");

        builder.HasIndex(v => v.Id)
            .IsUnique()
            .HasDatabaseName("IX_Vehicle_Id");

        builder.HasOne(v => v.Storage)
            .WithMany(s => s.Vehicles)
            .HasForeignKey(v => v.StorageId)
            .HasConstraintName("FK_Vehicle_Storage")
            .IsRequired();

        builder.HasOne(v => v.VehicleType)
            .WithMany(vt => vt.Vehicles)
            .HasForeignKey(v => v.VehicleTypeId)
            .HasConstraintName("FK_Vehicle_VehicleType")
            .IsRequired();

        builder.Property(v => v.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.HasIndex(v => v.Name)
            .IsUnique()
            .HasDatabaseName("IX_Vehicle_Name");

        builder.Property(v => v.Description)
            .HasMaxLength(250);

        builder.Property(v => v.Quantity)
            .IsRequired();
    }
}
