namespace Entity_Project
{
    partial class BrowseItems
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
            lblTitle = new Label();
            dgvItems = new DataGridView();
            btnRent = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(297, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(123, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Available Rental Items";
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(26, 250);
            dgvItems.Name = "dgvItems";
            dgvItems.Size = new Size(748, 150);
            dgvItems.TabIndex = 1;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            // 
            // btnRent
            // 
            btnRent.Location = new Point(93, 146);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(113, 23);
            btnRent.TabIndex = 2;
            btnRent.Text = "Rent Selected Item";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += btnRent_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(339, 146);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // BrowseItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnRent);
            Controls.Add(dgvItems);
            Controls.Add(lblTitle);
            Name = "BrowseItems";
            Text = "BrowseItems";
            Load += BrowseItems_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvItems;
        private Button btnRent;
        private Button btnBack;
    }
}