using ArmyHub.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyHub.Persistence.SqlServer.Configurations.EntityConfigurations;

public sealed class DeceaseConfiguration : IEntityTypeConfiguration<Decease>
{
    public void Configure(EntityTypeBuilder<Decease> builder)
    {
        builder.HasKey(d => d.Id)
            .HasName("PK_Decease");

        builder.HasIndex(d => d.Id)
            .IsUnique()
            .HasDatabaseName("IX_Decease_Id");

        builder.HasOne(d => d.DeceaseCountry)
            .WithMany(c => c.Deceases)
            .HasForeignKey(d => d.DeceaseCountryId)
            .HasConstraintName("FX_Decease_Country");

        builder.Property(d => d.DeceaseReason)
            .HasMaxLength(200);

        builder.Property(d => d.DeceaseDate)
            .IsRequired();

        builder.ToTable("Deceases");
    }
}
