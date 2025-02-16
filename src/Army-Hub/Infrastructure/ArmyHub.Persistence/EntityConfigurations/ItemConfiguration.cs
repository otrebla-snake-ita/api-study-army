using ArmyHub.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyHub.Persistence.EntityConfigurations;

public sealed class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.HasKey(i => i.Id)
            .HasName("PK_Item");

        builder.HasIndex(i => i.Id)
            .IsUnique()
            .HasDatabaseName("IX_Item_Id");

        builder.HasOne(i => i.Storage)
            .WithMany(s => s.Items)
            .HasForeignKey(i => i.StorageId)
            .HasConstraintName("FK_Item_Storage")
            .IsRequired();

        builder.HasOne(i => i.ItemType)
            .WithMany(it => it.Items)
            .HasForeignKey(i => i.ItemTypeId)
            .HasConstraintName("FK_Item_ItemType")
            .IsRequired();

        builder.Property(i => i.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.HasIndex(i => i.Name)
            .IsUnique()
            .HasDatabaseName("IX_Item_Name");

        builder.Property(i => i.Description)
            .HasMaxLength(250);

        builder.Property(i => i.Quantity)
            .IsRequired();

        builder.ToTable("Items");
    }
}