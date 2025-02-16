using ArmyHub.Domain.Extensions;
using ArmyHub.Domain.Models;
using ArmyHub.Domain.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyHub.Persistence.EntityConfigurations;

public sealed class WeaponTypeConfiguration : IEntityTypeConfiguration<WeaponType>
{
    public void Configure(EntityTypeBuilder<WeaponType> builder)
    {
        builder.HasData(Enum.GetValues<WeaponTypeId>()
            .Select(e => new WeaponType()
            {
                Id = e,
                Name = e.ToString().SplitCapitalLetters()
            }));

        builder.HasKey(wt => wt.Id)
            .HasName("PK_WeaponType");

        builder.Property(wt => wt.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.HasIndex(wt => wt.Name)
            .IsUnique();

        builder.Property(wt => wt.Description)
            .HasMaxLength(200);

        builder.ToTable("WeaponTypes");
    }
}
