using ArmyHub.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyHub.Persistence.EntityConfigurations;

public sealed class SoldierConfiguration : IEntityTypeConfiguration<Soldier>
{
    public void Configure(EntityTypeBuilder<Soldier> builder)
    {
        builder.HasKey(s => s.Id)
            .HasName("PK_Soldier");

        builder.HasIndex(s => s.Id)
            .IsUnique()
            .HasDatabaseName("IX_Soldier_Id");

        builder.HasOne(s => s.Grade)
            .WithMany(g => g.Soldiers)
            .HasForeignKey(s => s.GradeId)
            .HasConstraintName("FK_Soldier_Grade")
            .IsRequired();

        builder.HasOne(s => s.MilitaryRole)
            .WithMany(g => g.Soldiers)
            .HasForeignKey(s => s.MilitaryRoleId)
            .HasConstraintName("FK_Soldier_MilitaryRole");

        builder.HasOne(s => s.Army)
            .WithMany(a => a.Soldiers)
            .HasForeignKey(s => s.ArmyId)
            .HasConstraintName("FK_Soldier_Army")
            .IsRequired();

        builder.HasOne(s => s.Unit)
            .WithMany(u => u.Soldiers)
            .HasForeignKey(s => s.UnitId)
            .HasConstraintName("FK_Soldier_Unit");

        // TODO: Check Interceptor in EF Core for this property
        builder.Property(s => s.IsAlive)
            .HasDefaultValue(false);

        builder.Property(s => s.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(s => s.Surname)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(s => s.EngagementStartDate)
            .IsRequired();

        builder.ToTable("Soldiers");
    }
}
