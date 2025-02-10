namespace ArmyHub.Domain.Models;

public class Storage
{
    public uint Id { get; set; }
    public uint ArmyId { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    #region Navigation Properties

    public Army? Army { get; set; }
    public ICollection<Vehicle> Vehicles { get; set; } = [];
    public ICollection<Weapon> Weapons { get; set; } = [];
    public ICollection<Item> Items { get; set; } = [];
    public ICollection<Ammunition> Ammunitions { get; set; } = [];

    #endregion
}
