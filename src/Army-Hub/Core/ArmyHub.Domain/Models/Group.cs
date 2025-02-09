namespace ArmyHub.Domain.Models;

public class Group
{
    public uint Id { get; set; }
    public uint ArmyId { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    #region Navigation Properties

    public Army? Army { get; set; }
    public ICollection<Unit> Units { get; set; } = [];

    #endregion
}
