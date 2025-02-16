using ArmyHub.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyHub.Persistence.EntityConfigurations;

public sealed class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasKey(g => g.Id)
            .HasName("PK_Group");

        builder.HasIndex(g => g.Id)
            .IsUnique()
            .HasDatabaseName("IX_Group_Id");

        builder.HasOne(b => b.Army)
            .WithMany(a => a.Groups)
            .HasForeignKey(b => b.ArmyId)
            .HasConstraintName("FX_Group_Army")
            .IsRequired();

        builder.Property(g => g.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(g => g.Description)
            .HasMaxLength(200);

        builder.ToTable("Groups");
    }
}
