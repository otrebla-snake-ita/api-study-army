namespace ArmyHub.Domain.Models;

public class Country
{
    public uint Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    #region Navigation Properties

    public ICollection<Army> Armies { get; set; } = [];
    public ICollection<Death> Deaths { get; set; } = [];

    #endregion
}
