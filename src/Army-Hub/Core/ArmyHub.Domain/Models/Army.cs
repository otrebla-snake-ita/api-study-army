namespace ArmyHub.Domain.Models;

public class Army
{
    public uint Id { get; set; }
    public uint CountryId { get; set; }
    public required string Name { get; set; }

    #region Navigation Properties

    public Country? Country { get; set; }
    public ICollection<Group> Groups { get; set; } = [];
    public ICollection<Soldier> Soldiers { get; set; } = [];
    public ICollection<Storage> Storages { get; set; } = [];

    #endregion
}
