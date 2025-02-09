using ArmyHub.Domain.Models.Enums;

namespace ArmyHub.Domain.Models;

public class MilitaryRole
{
    public MilitaryRoleId Id { get; set; }
    public string? Description { get; set; }

    #region Navigation Properties 

    public ICollection<Soldier> Soldiers { get; set; } = [];

    #endregion
}
