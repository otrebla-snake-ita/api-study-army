using ArmyHub.Domain.Models.Enums;

namespace ArmyHub.Domain.Models;

public class Ammunition
{
    public uint Id { get; set; }
    public AmmunitionTypeId AmmunitionId { get; set; }
    public string? Description { get; set; }
    public ulong Quantity { get; set; }

    #region Navigation Properties

    public Ammunition? AmmunitionType { get; set; }

    #endregion
}
