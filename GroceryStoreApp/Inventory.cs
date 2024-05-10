using System.Collections.Generic;

public class Inventory
{
    private Dictionary<string, List<InventoryItem>> inventory;

    public Inventory()
    {
        inventory = new Dictionary<string, List<InventoryItem>>();
    }

    public void AddItem(InventoryItem item)
    {
        if (!inventory.ContainsKey(item.Category))
        {
            inventory[item.Category] = new List<InventoryItem>();
        }
        inventory[item.Category].Add(item);
    }

    public void RemoveItem(InventoryItem item)
    {
        if (inventory.ContainsKey(item.Category))
        {
            inventory[item.Category].Remove(item);
        }
    }

    public Dictionary<string, List<InventoryItem>> GetInventory()
    {
        return inventory;
    }
}
