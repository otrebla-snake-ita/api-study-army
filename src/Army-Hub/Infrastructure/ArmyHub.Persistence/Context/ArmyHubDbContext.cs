using ArmyHub.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ArmyHub.Persistence.Context;

internal class ArmyHubDbContext : DbContext
{

    #region DbSets

    public DbSet<Ammunition> Ammunitions { get; set; }
    public DbSet<AmmunitionType> AmmunitionTypes { get; set; }
    public DbSet<Army> Armies { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Decease> Deceases { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemType> ItemTypes { get; set; }
    public DbSet<MilitaryRole> MilitaryRoles { get; set; }
    public DbSet<Soldier> Soldiers { get; set; }
    public DbSet<Storage> Storages { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<VehicleType> VehicleTypes { get; set; }
    public DbSet<Weapon> Weapons { get; set; }
    public DbSet<WeaponType> WeaponTypes { get; set; }

    #endregion

    public ArmyHubDbContext(DbContextOptions<ArmyHubDbContext> options) : base(options)
    { }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    base.OnConfiguring(optionsBuilder);
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
