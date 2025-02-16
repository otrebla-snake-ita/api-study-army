using ArmyHub.Domain.Models.Enums;

namespace ArmyHub.Domain.Models;

public class VehicleType
{
    public VehicleTypeId Id { get; set; }
    public required string Name { get; set; }

    #region Navigation Properties

    public ICollection<Vehicle> Vehicles { get; set; } = [];

    #endregion
}
