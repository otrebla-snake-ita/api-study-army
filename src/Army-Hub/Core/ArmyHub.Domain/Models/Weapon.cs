using ArmyHub.Domain.Models.Enums;

namespace ArmyHub.Domain.Models;

public class Weapon
{
    public uint Id { get; set; }
    public uint StorageId { get; set; }
    public uint AmmunitionId { get; set; }
    public WeaponTypeId WeaponTypeId { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    #region Navigation Properties

    public Storage? Storage { get; set; }
    public Ammunition? Ammunition { get; set; }
    public WeaponType? WeaponType { get; set; }

    #endregion
}
