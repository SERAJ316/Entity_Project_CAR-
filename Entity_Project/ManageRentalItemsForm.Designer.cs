namespace Entity_Project
{
    partial class ManageRentalItemsForm
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
            dgvRentalItems = new DataGridView();
            btnEditItem = new Button();
            btnAddItem = new Button();
            btnDeleteItem = new Button();
            btnBack = new Button();
            lblItemName = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            txtItemName = new TextBox();
            txtCategory = new TextBox();
            txtPrice = new TextBox();
            chkIsAvailable = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvRentalItems).BeginInit();
            SuspendLayout();
            // 
            // dgvRentalItems
            // 
            dgvRentalItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalItems.Location = new Point(503, 34);
            dgvRentalItems.Name = "dgvRentalItems";
            dgvRentalItems.Size = new Size(240, 150);
            dgvRentalItems.TabIndex = 0;
            dgvRentalItems.CellClick += dgvRentalItems_CellClick;
            // 
            // btnEditItem
            // 
            btnEditItem.Location = new Point(577, 285);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(75, 23);
            btnEditItem.TabIndex = 1;
            btnEditItem.Text = "Edit Selected Item";
            btnEditItem.UseVisualStyleBackColor = true;
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(399, 273);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(277, 307);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(75, 23);
            btnDeleteItem.TabIndex = 3;
            btnDeleteItem.Text = "Delete Selected Item";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(108, 285);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(48, 45);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(66, 15);
            lblItemName.TabIndex = 5;
            lblItemName.Text = "Item Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(48, 101);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(48, 169);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(76, 15);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price Per Day";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(254, 44);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(100, 23);
            txtItemName.TabIndex = 8;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(254, 101);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(100, 23);
            txtCategory.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(252, 169);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 10;
            // 
            // chkIsAvailable
            // 
            chkIsAvailable.AutoSize = true;
            chkIsAvailable.Location = new Point(156, 216);
            chkIsAvailable.Name = "chkIsAvailable";
            chkIsAvailable.Size = new Size(90, 19);
            chkIsAvailable.TabIndex = 11;
            chkIsAvailable.Text = "Is Available?";
            chkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // ManageRentalItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkIsAvailable);
            Controls.Add(txtPrice);
            Controls.Add(txtCategory);
            Controls.Add(txtItemName);
            Controls.Add(lblPrice);
            Controls.Add(lblCategory);
            Controls.Add(lblItemName);
            Controls.Add(btnBack);
            Controls.Add(btnDeleteItem);
            Controls.Add(btnAddItem);
            Controls.Add(btnEditItem);
            Controls.Add(dgvRentalItems);
            Name = "ManageRentalItemsForm";
            Text = "ManageRentalItemsForm";
            Load += ManageRentalItemsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRentalItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRentalItems;
        private Button btnEditItem;
        private Button btnAddItem;
        private Button btnDeleteItem;
        private Button btnBack;
        private Label lblItemName;
        private Label lblCategory;
        private Label lblPrice;
        private TextBox txtItemName;
        private TextBox txtCategory;
        private TextBox txtPrice;
        private CheckBox chkIsAvailable;
    }
}