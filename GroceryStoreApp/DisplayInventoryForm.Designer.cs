namespace GroceryStoreApp
{
    partial class DisplayInventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxInventory = new ListBox();
            SuspendLayout();
            // 
            // listBoxInventory
            // 
            listBoxInventory.FormattingEnabled = true;
            listBoxInventory.ItemHeight = 25;
            listBoxInventory.Location = new Point(73, 21);
            listBoxInventory.Name = "listBoxInventory";
            listBoxInventory.Size = new Size(382, 179);
            listBoxInventory.TabIndex = 0;
            listBoxInventory.SelectedIndexChanged += listBoxInventory_SelectedIndexChanged;
            // 
            // DisplayInventoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxInventory);
            Name = "DisplayInventoryForm";
            Text = "DisplayInventoryForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxInventory;
    }
}