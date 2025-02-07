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
            lblWelcome.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(297, 53);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(244, 33);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, [User Name]!";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(128, 150);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(135, 32);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Show Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(363, 150);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(117, 32);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse Rental Items";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnHistory
            // 
            btnHistory.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistory.Location = new Point(348, 289);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(123, 34);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "Rental History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(112, 289);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(136, 34);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return Rental Item";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(587, 215);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 29);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
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