using ArmyHub.Domain.Models.Enums;

namespace ArmyHub.Domain.Models;

public class Grade
{
    public GradeId Id { get; set; }
    public required string Description { get; set; }

    #region Navigation Properties

    public ICollection<Soldier> Soldiers { get; set; } = [];

    #endregion
}
