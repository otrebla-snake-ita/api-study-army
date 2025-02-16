using ArmyHub.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyHub.Persistence.EntityConfigurations;

public sealed class UnitConfiguration : IEntityTypeConfiguration<Unit>
{
    public void Configure(EntityTypeBuilder<Unit> builder)
    {
        builder.HasKey(u => u.Id)
            .HasName("PK_Unit");

        builder.HasIndex(u => u.Id)
            .IsUnique()
            .HasDatabaseName("IX_Unit_Id");

        builder.HasOne(u => u.Group)
            .WithMany(g => g.Units)
            .HasForeignKey(u => u.GroupId)
            .HasConstraintName("FK_Unit_Group")
            .IsRequired();

        builder.Property(u => u.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.HasIndex(u => u.Name)
            .IsUnique()
            .HasDatabaseName("IX_Unit_Name");

        builder.Property(u => u.Description)
            .HasMaxLength(250);

        builder.ToTable("Units");
    }
}
