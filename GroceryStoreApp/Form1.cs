namespace GroceryStoreApp
{
    public partial class Form1 : Form

    {
        private Inventory inventory;
        public Form1()
        {
            InitializeComponent();
            inventory = new Inventory();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                string category = txtCategory.Text;

                InventoryItem newItem = new InventoryItem(name, price, quantity, category);
                inventory.AddItem(newItem);

                MessageBox.Show("Item added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding item: {ex.Message}");
            }
        }

        private void txtRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                string category = txtCategory.Text;

                InventoryItem itemToRemove = new InventoryItem(name, price, quantity, category);
                inventory.RemoveItem(itemToRemove);

                MessageBox.Show("Item removed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing item: {ex.Message}");
            }
        }

        private void btnDisplayInventory_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayInventoryForm displayForm = new DisplayInventoryForm(inventory);
                displayForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying inventory: {ex.Message}");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
