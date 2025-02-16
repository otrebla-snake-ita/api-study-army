using ArmyHub.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyHub.Persistence.EntityConfigurations;

public sealed class StorageConfiguration : IEntityTypeConfiguration<Storage>
{
    public void Configure(EntityTypeBuilder<Storage> builder)
    {
        builder.HasKey(s => s.Id)
            .HasName("PK_Storage");

        builder.HasIndex(s => s.Id)
            .IsUnique()
            .HasDatabaseName("IX_Storage_Id");

        builder.HasOne(s => s.Army)
            .WithMany(a => a.Storages)
            .HasForeignKey(s => s.ArmyId)
            .HasConstraintName("FK_Storage_Army")
            .IsRequired();

        builder.Property(s => s.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.HasIndex(s => s.Name)
            .IsUnique()
            .HasDatabaseName("IX_Storage_Name");

        builder.Property(s => s.Description)
            .HasMaxLength(250);

        builder.ToTable("Storages");
    }
}
