using ArmyHub.Domain.Models.Enums;

namespace ArmyHub.Domain.Models;

public class ItemType
{
    public ItemTypeId Id { get; set; }
    public required string Name { get; set; }

    #region Navigation Properties

    public ICollection<Item> Items { get; set; } = [];

    #endregion
}
