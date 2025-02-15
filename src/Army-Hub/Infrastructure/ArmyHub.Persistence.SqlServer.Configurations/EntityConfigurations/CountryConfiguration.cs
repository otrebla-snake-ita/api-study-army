using ArmyHub.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyHub.Persistence.SqlServer.Configurations.EntityConfigurations;

public sealed class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.HasKey(c => c.Id)
            .HasName("PK_Country");

        builder.HasIndex(c => c.Id)
            .IsUnique()
            .HasDatabaseName("IX_Country_Id");

        builder.Property(c => c.Name)
            .IsRequired();

        builder.HasIndex(c => c.Name)
            .HasDatabaseName("IX_Country_Name");

        builder.Property(c => c.Description);

        builder.ToTable("Countries");
    }
}
