namespace Entity_Project
{
    partial class AdminForm
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
            lblAdminPanel = new Label();
            btnManageUsers = new Button();
            btnManageItems = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblAdminPanel
            // 
            lblAdminPanel.AutoSize = true;
            lblAdminPanel.Location = new Point(456, 94);
            lblAdminPanel.Name = "lblAdminPanel";
            lblAdminPanel.Size = new Size(75, 15);
            lblAdminPanel.TabIndex = 0;
            lblAdminPanel.Text = "Admin Panel";
            // 
            // btnManageUsers
            // 
            btnManageUsers.Location = new Point(439, 207);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(143, 23);
            btnManageUsers.TabIndex = 1;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnManageItems
            // 
            btnManageItems.Location = new Point(419, 270);
            btnManageItems.Name = "btnManageItems";
            btnManageItems.Size = new Size(163, 23);
            btnManageItems.TabIndex = 2;
            btnManageItems.Text = "Manage Rental Items";
            btnManageItems.UseVisualStyleBackColor = true;
            btnManageItems.Click += btnManageItems_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(227, 261);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnManageItems);
            Controls.Add(btnManageUsers);
            Controls.Add(lblAdminPanel);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminPanel;
        private Button btnManageUsers;
        private Button btnManageItems;
        private Button btnBack;
    }
}