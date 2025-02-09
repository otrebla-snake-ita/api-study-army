using ArmyHub.Domain.Models.Enums;

namespace ArmyHub.Domain.Models;

public class Soldier
{
    public uint Id { get; set; }
    public GradeId GradeId { get; set; }
    public MilitaryRoleId? MilitaryRoleId { get; set; } // TODO: Per Business Logic, some Miiltary Roles are not compatible with Grades (e.g. a commander cannot be a tank driver).
    public uint ArmyId { get; set; }
    public uint? UnitId { get; set; }
    public uint? DeathId { get; set; }
    public bool IsAlive { get; set; } // TODO: Implement this with trigger. If DeathId is not null, IsAlive is false.
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public DateOnly EngagementStartDate { get; set; }
    public DateOnly? EngagementEndDate { get; set; }

    #region Navigation Properties

    public Grade? Grade { get; set; }
    public MilitaryRole? MilitaryRole { get; set; }
    public Army? Army { get; set; }
    public Unit? Unit { get; set; }
    public Death? Death { get; set; }

    #endregion
}
