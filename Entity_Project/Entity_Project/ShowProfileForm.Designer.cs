namespace Entity_Project
{
    partial class ShowProfileForm
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
            label1 = new Label();
            lblDisplayName = new Label();
            label3 = new Label();
            lblDisplayEmail = new Label();
            btnEditProfile = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 64);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // lblDisplayName
            // 
            lblDisplayName.AutoSize = true;
            lblDisplayName.Location = new Point(483, 64);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(38, 15);
            lblDisplayName.TabIndex = 1;
            lblDisplayName.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(327, 145);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // lblDisplayEmail
            // 
            lblDisplayEmail.AutoSize = true;
            lblDisplayEmail.Location = new Point(483, 145);
            lblDisplayEmail.Name = "lblDisplayEmail";
            lblDisplayEmail.Size = new Size(38, 15);
            lblDisplayEmail.TabIndex = 3;
            lblDisplayEmail.Text = "label4";
            // 
            // btnEditProfile
            // 
            btnEditProfile.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditProfile.Location = new Point(294, 264);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(94, 32);
            btnEditProfile.TabIndex = 4;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = true;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(504, 264);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 32);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ShowProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnEditProfile);
            Controls.Add(lblDisplayEmail);
            Controls.Add(label3);
            Controls.Add(lblDisplayName);
            Controls.Add(label1);
            Name = "ShowProfileForm";
            Text = "ShowProfileForm";
            Load += ShowProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblDisplayName;
        private Label label3;
        private Label lblDisplayEmail;
        private Button btnEditProfile;
        private Button btnBack;
    }
}