using ArmyHub.Domain.Models.Enums;

namespace ArmyHub.Domain.Models;

public class WeaponType
{
    public WeaponTypeId Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    #region Navigation Properties   

    public ICollection<Weapon> Weapons { get; set; } = [];

    #endregion
}
