using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStoreApp
{
    public partial class DisplayInventoryForm : Form
    {
        private Inventory inventory;
        public DisplayInventoryForm(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
            DisplayInventory();
        }

        private void listBoxInventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void DisplayInventory()
        {
            Dictionary<string, List<InventoryItem>> inventoryData = inventory.GetInventory();

            foreach (var category in inventoryData.Keys)
            {
                listBoxInventory.Items.Add($"Category: {category}");
                foreach (var item in inventoryData[category])
                {
                    listBoxInventory.Items.Add($"Name: {item.Name}, Price: {item.Price}, Quantity: {item.Quantity}");
                }
                listBoxInventory.Items.Add("");
            }
        }
    }
}
