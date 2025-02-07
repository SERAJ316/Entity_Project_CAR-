namespace Entity_Project
{
    partial class ManageUsersForm
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
            dgvUsers = new DataGridView();
            btnAddUser = new Button();
            btnEditUser = new Button();
            btnDeleteUser = new Button();
            btnBack = new Button();
            lblFullName = new Label();
            txtEmail = new Label();
            txtPassword = new Label();
            txtFullName = new TextBox();
            textEmail = new TextBox();
            textPassword = new TextBox();
            chkIsAdmin = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(466, 71);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(240, 150);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(304, 300);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(75, 23);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(434, 300);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(75, 23);
            btnEditUser.TabIndex = 2;
            btnEditUser.Text = "Edit Selected User";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(181, 300);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(75, 23);
            btnDeleteUser.TabIndex = 3;
            btnDeleteUser.Text = "Delete Selected User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(65, 300);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(65, 34);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(61, 15);
            lblFullName.TabIndex = 5;
            lblFullName.Text = "Full Name";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Location = new Point(65, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(36, 15);
            txtEmail.TabIndex = 6;
            txtEmail.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Location = new Point(65, 142);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(57, 15);
            txtPassword.TabIndex = 7;
            txtPassword.Text = "Password";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(215, 34);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(100, 23);
            txtFullName.TabIndex = 8;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(215, 86);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(100, 23);
            textEmail.TabIndex = 9;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(215, 139);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(100, 23);
            textPassword.TabIndex = 10;
            // 
            // chkIsAdmin
            // 
            chkIsAdmin.AutoSize = true;
            chkIsAdmin.Location = new Point(153, 205);
            chkIsAdmin.Name = "chkIsAdmin";
            chkIsAdmin.Size = new Size(78, 19);
            chkIsAdmin.TabIndex = 11;
            chkIsAdmin.Text = "Is Admin?";
            chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // ManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkIsAdmin);
            Controls.Add(textPassword);
            Controls.Add(textEmail);
            Controls.Add(txtFullName);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblFullName);
            Controls.Add(btnBack);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnEditUser);
            Controls.Add(btnAddUser);
            Controls.Add(dgvUsers);
            Name = "ManageUsersForm";
            Text = "ManageUsersForm";
            Load += ManageUsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private Button btnAddUser;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private Button btnBack;
        private Label lblFullName;
        private Label txtEmail;
        private Label txtPassword;
        private TextBox txtFullName;
        private TextBox textEmail;
        private TextBox textPassword;
        private CheckBox chkIsAdmin;
    }
}