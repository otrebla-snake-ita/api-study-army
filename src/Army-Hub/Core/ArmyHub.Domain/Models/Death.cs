namespace ArmyHub.Domain.Models;

public class Death
{
    public uint Id { get; set; }
    public uint SoldierId { get; set; }
    public uint DeathCountryId { get; set; }
    public string? DeathReason { get; set; }
    public DateTime DeathDate { get; set; }

    #region Navigation Properties

    public Soldier? Soldier { get; set; }
    public Country? DeathCountry { get; set; }

    #endregion
}
