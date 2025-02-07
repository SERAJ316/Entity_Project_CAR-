namespace Entity_Project
{
    partial class Edit_Profile
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
            lblFullName = new Label();
            lblEmail = new Label();
            lblOldPassword = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtOldPassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNewPassword = new TextBox();
            txtConfirm = new TextBox();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(222, 51);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(61, 15);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(222, 145);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Location = new Point(222, 197);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(79, 15);
            lblOldPassword.TabIndex = 2;
            lblOldPassword.Text = "Old Password";
            lblOldPassword.Click += lblOldPassword_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(420, 56);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(100, 23);
            txtFullName.TabIndex = 3;
            txtFullName.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(420, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(420, 197);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(100, 23);
            txtOldPassword.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(262, 327);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(420, 327);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 227);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 8;
            label1.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 264);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Confirm";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(420, 235);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(100, 23);
            txtNewPassword.TabIndex = 10;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(420, 264);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(100, 23);
            txtConfirm.TabIndex = 11;
            // 
            // Edit_Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtConfirm);
            Controls.Add(txtNewPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtOldPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(lblOldPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblFullName);
            Name = "Edit_Profile";
            Text = "Edit_Profile";
            Load += Edit_Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullName;
        private Label lblEmail;
        private Label lblOldPassword;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtOldPassword;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private TextBox txtNewPassword;
        private TextBox txtConfirm;
    }
}