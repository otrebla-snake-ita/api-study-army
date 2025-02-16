using ArmyHub.Domain.Extensions;
using ArmyHub.Domain.Models;
using ArmyHub.Domain.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyHub.Persistence.EntityConfigurations;

public sealed class VehicleTypeConfiguration : IEntityTypeConfiguration<VehicleType>
{
    public void Configure(EntityTypeBuilder<VehicleType> builder)
    {
        builder.HasData(Enum.GetValues<VehicleTypeId>()
            .Select(e => new VehicleType()
            {
                Id = e,
                Name = e.ToString().SplitCapitalLetters()
            }));

        builder.HasKey(vt => vt.Id)
            .HasName("PK_VehicleType");

        builder.HasIndex(vt => vt.Id)
            .IsUnique();

        builder.Property(vt => vt.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.HasIndex(vt => vt.Name)
            .IsUnique();

        builder.ToTable("VehicleTypes");
    }
}
