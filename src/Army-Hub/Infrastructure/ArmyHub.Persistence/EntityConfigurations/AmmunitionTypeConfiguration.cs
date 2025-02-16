using ArmyHub.Domain.Models;
using ArmyHub.Domain.Models.Enums;
using ArmyHub.Domain.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyHub.Persistence.EntityConfigurations;

public sealed class AmmunitionTypeConfiguration : IEntityTypeConfiguration<AmmunitionType>
{
    public void Configure(EntityTypeBuilder<AmmunitionType> builder)
    {
        builder.HasData(Enum.GetValues<AmmunitionTypeId>()
            .Select(e => new AmmunitionType()
            {
                Id = e,
                Name = e.ToString().SplitCapitalLetters()
            }));

        builder.HasKey(at => at.Id)
            .HasName("PK_AmmunitionType");

        builder.HasIndex(at => at.Id)
            .IsUnique();
        
        builder.Property(at => at.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.HasIndex(at => at.Name)
            .IsUnique();

        builder.ToTable("AmmunitionTypes");
    }
}
