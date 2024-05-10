public class InventoryItem
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Category { get; set; }

    public InventoryItem(string name, double price, int quantity, string category)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
        Category = category;
    }
}
