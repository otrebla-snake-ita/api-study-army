namespace ArmyHub.Domain.Models;

public class Unit
{
    public uint Id { get; set; }
    public uint GroupId { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    #region Navigation Properties

    public Group? Group { get; set; }
    public ICollection<Soldier> Soldiers { get; set; } = [];

    #endregion
}
