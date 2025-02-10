namespace ArmyHub.Domain.Models;

public class Decease
{
    public uint Id { get; set; }
    public uint SoldierId { get; set; }
    public uint DeceaseCountryId { get; set; }
    public string? DeceaseReason { get; set; }
    public DateTime DeceaseDate { get; set; }

    #region Navigation Properties

    public Soldier? Soldier { get; set; }
    public Country? DeceaseCountry { get; set; }

    #endregion
}
