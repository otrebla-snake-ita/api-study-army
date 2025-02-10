using ArmyHub.Domain.Models.Enums;

namespace ArmyHub.Domain.Models;

public class Weapon
{
    public uint Id { get; set; }
    public uint StorageId { get; set; }
    public AmmunitionTypeId AmmunitionTypeId { get; set; }
    public WeaponTypeId WeaponTypeId { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }

    #region Navigation Properties

    public Storage? Storage { get; set; }
    public AmmunitionType? AmmunitionType { get; set; }
    public WeaponType? WeaponType { get; set; }
    public ICollection<Vehicle> Vehicles { get; set; } = [];

    #endregion
}
