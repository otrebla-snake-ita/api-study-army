using ArmyHub.Domain.Extensions;
using ArmyHub.Domain.Models;
using ArmyHub.Domain.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyHub.Persistence.SqlServer.Configurations.EntityConfigurations;

public sealed class GradeConfiguration : IEntityTypeConfiguration<Grade>
{
    public void Configure(EntityTypeBuilder<Grade> builder)
    {
        builder.HasData(Enum.GetValues<GradeId>()
            .Select(e => new Grade()
            {
                Id = e,
                Name = e.ToString().SplitCapitalLetters()
            }));

        builder.HasKey(g => g.Id)
            .HasName("PK_Grade");

        builder.HasIndex(g => g.Id)
            .IsUnique()
            .HasDatabaseName("IX_Grade_Id");

        builder.Property(g => g.Name)
            .HasMaxLength(75)
            .IsRequired();

        builder.HasIndex(g => g.Name)
            .IsUnique()
            .HasDatabaseName("IX_Grade_Name");

        builder.ToTable("Grades");
    }
}
