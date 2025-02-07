namespace Entity_Project
{
    partial class DashboardForm
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
            lblWelcome = new Label();
            btnProfile = new Button();
            btnBrowse = new Button();
            btnHistory = new Button();
            btnReturn = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(495, 115);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(132, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, [User Name]!";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(357, 147);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(135, 23);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Show Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(363, 214);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(117, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse Rental Items";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(588, 247);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(123, 23);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "Rental History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(131, 214);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(136, 23);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return Rental Item";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(378, 309);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnReturn);
            Controls.Add(btnHistory);
            Controls.Add(btnBrowse);
            Controls.Add(btnProfile);
            Controls.Add(lblWelcome);
            Name = "DashboardForm";
            Text = "DashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnProfile;
        private Button btnBrowse;
        private Button btnHistory;
        private Button btnReturn;
        private Button btnLogout;
    }
}