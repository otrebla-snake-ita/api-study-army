using ArmyHub.Domain.Extensions;
using ArmyHub.Domain.Models;
using ArmyHub.Domain.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyHub.Persistence.EntityConfigurations;

public sealed class ItemTypeConfiguration : IEntityTypeConfiguration<ItemType>
{
    public void Configure(EntityTypeBuilder<ItemType> builder)
    {
        builder.HasData(Enum.GetValues<ItemTypeId>()
            .Select(e => new ItemType()
            {
                Id = e,
                Name = e.ToString().SplitCapitalLetters()
            }));

        builder.HasKey(it => it.Id)
            .HasName("PK_ItemType");

        builder.HasIndex(it => it.Id)
            .IsUnique()
            .HasDatabaseName("IX_ItemType_Id");

        builder.Property(it => it.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.HasIndex(it => it.Name)
            .IsUnique()
            .HasDatabaseName("IX_ItemType_Name");

        builder.ToTable("ItemTypes");
    }
}
