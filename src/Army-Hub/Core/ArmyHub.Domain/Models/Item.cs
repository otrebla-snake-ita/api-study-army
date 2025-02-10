using ArmyHub.Domain.Models.Enums;

namespace ArmyHub.Domain.Models;

public class Item
{
    public uint Id { get; set; }
    public uint StorageId { get; set; }
    public ItemTypeId ItemTypeId { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }

    #region Navigation Properties

    public Storage? Storage { get; set; }
    public ItemType? ItemType { get; set; }

    #endregion
}
