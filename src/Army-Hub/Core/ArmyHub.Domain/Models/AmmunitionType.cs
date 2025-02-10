using ArmyHub.Domain.Models.Enums;

namespace ArmyHub.Domain.Models;

public class AmmunitionType
{
    public AmmunitionTypeId Id { get; set; }
    public required string Name { get; set; }

    #region Navigation Properties

    public ICollection<Weapon> Weapons { get; set; } = [];
    public ICollection<Ammunition> Ammunitions { get; set; } = [];

    #endregion
}
