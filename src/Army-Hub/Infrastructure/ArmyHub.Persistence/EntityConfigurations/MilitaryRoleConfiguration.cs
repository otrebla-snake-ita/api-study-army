using ArmyHub.Domain.Extensions;
using ArmyHub.Domain.Models;
using ArmyHub.Domain.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyHub.Persistence.EntityConfigurations;

public sealed class MilitaryRoleConfiguration : IEntityTypeConfiguration<MilitaryRole>
{
    public void Configure(EntityTypeBuilder<MilitaryRole> builder)
    {
        builder.HasData(Enum.GetValues<MilitaryRoleId>()
            .Select(e => new MilitaryRole()
            {
                Id = e,
                Name = e.ToString().SplitCapitalLetters()
            }));

        builder.HasKey(mr => mr.Id)
            .HasName("PK_MilitaryRole_Id");

        builder.HasIndex(mr => mr.Id)
            .IsUnique()
            .HasDatabaseName("IX_MilitaryRole_Id");

        builder.Property(mr => mr.Name)
            .HasMaxLength(100);

        builder.HasIndex(mr => mr.Name)
            .IsUnique()
            .HasDatabaseName("IX_MilitaryRole_Name");

        builder.ToTable("MilitaryRoles");
    }
}
