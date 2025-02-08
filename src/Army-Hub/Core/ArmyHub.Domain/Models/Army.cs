namespace ArmyHub.Domain.Models;

public class Army
{
    public uint Id { get; set; }
    public uint CountryId { get; set; }
    public required string Name { get; set; }
}
