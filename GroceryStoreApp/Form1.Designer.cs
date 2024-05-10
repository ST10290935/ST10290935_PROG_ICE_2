namespace GroceryStoreApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddItem = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtCategory = new TextBox();
            txtName = new TextBox();
            txtRemoveItem = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnDisplayInventory = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(97, 30);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(112, 34);
            btnAddItem.TabIndex = 0;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 91);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 148);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 2;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 88);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 3;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 154);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 4;
            label4.Text = "Category";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(97, 148);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(421, 85);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 31);
            txtQuantity.TabIndex = 6;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(421, 148);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(150, 31);
            txtCategory.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(97, 85);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 8;
            // 
            // txtRemoveItem
            // 
            txtRemoveItem.Location = new Point(97, 209);
            txtRemoveItem.Name = "txtRemoveItem";
            txtRemoveItem.Size = new Size(136, 34);
            txtRemoveItem.TabIndex = 9;
            txtRemoveItem.Text = "Remove Item";
            txtRemoveItem.UseVisualStyleBackColor = true;
            txtRemoveItem.Click += txtRemoveItem_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 267);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 10;
            label5.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 317);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 11;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(317, 267);
            label7.Name = "label7";
            label7.Size = new Size(80, 25);
            label7.TabIndex = 12;
            label7.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(317, 317);
            label8.Name = "label8";
            label8.Size = new Size(84, 25);
            label8.TabIndex = 13;
            label8.Text = "Category";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 267);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 317);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(421, 267);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(421, 317);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 17;
            // 
            // btnDisplayInventory
            // 
            btnDisplayInventory.Location = new Point(97, 371);
            btnDisplayInventory.Name = "btnDisplayInventory";
            btnDisplayInventory.Size = new Size(112, 34);
            btnDisplayInventory.TabIndex = 18;
            btnDisplayInventory.Text = "Display";
            btnDisplayInventory.UseVisualStyleBackColor = true;
            btnDisplayInventory.Click += btnDisplayInventory_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(242, 371);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 478);
            Controls.Add(btnExit);
            Controls.Add(btnDisplayInventory);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtRemoveItem);
            Controls.Add(txtName);
            Controls.Add(txtCategory);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddItem);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtCategory;
        private TextBox txtName;
        private Button txtRemoveItem;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnDisplayInventory;
        private Button btnExit;
    }
}
