using ArmyHub.Domain.Models.Enums;

namespace ArmyHub.Domain.Models;

public class Vehicle
{
    public uint Id { get; set; }
    public uint StorageId { get; set; }
    public VehicleTypeId VehicleTypeId { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public DateOnly PurchaseDate { get; set; }

    #region Navigation Properties

    public Storage? Storage { get; set; }
    public VehicleType? VehicleType { get; set; }

    #endregion
}
