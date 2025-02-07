namespace Entity_Project
{
    partial class ReturnForm
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
            lblReturnTitle = new Label();
            lblRentalId = new Label();
            txtRentalId = new TextBox();
            btnReturnItem = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblReturnTitle
            // 
            lblReturnTitle.AutoSize = true;
            lblReturnTitle.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReturnTitle.Location = new Point(291, 50);
            lblReturnTitle.Name = "lblReturnTitle";
            lblReturnTitle.Size = new Size(250, 36);
            lblReturnTitle.TabIndex = 0;
            lblReturnTitle.Text = "Return a Rented Item";
            // 
            // lblRentalId
            // 
            lblRentalId.AutoSize = true;
            lblRentalId.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRentalId.Location = new Point(278, 151);
            lblRentalId.Name = "lblRentalId";
            lblRentalId.Size = new Size(68, 21);
            lblRentalId.TabIndex = 1;
            lblRentalId.Text = "Rental ID";
            // 
            // txtRentalId
            // 
            txtRentalId.Location = new Point(509, 151);
            txtRentalId.Name = "txtRentalId";
            txtRentalId.Size = new Size(100, 23);
            txtRentalId.TabIndex = 2;
            // 
            // btnReturnItem
            // 
            btnReturnItem.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturnItem.Location = new Point(453, 290);
            btnReturnItem.Name = "btnReturnItem";
            btnReturnItem.Size = new Size(115, 33);
            btnReturnItem.TabIndex = 3;
            btnReturnItem.Text = "Return Item";
            btnReturnItem.UseVisualStyleBackColor = true;
            btnReturnItem.Click += btnReturnItem_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(300, 290);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 33);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnReturnItem);
            Controls.Add(txtRentalId);
            Controls.Add(lblRentalId);
            Controls.Add(lblReturnTitle);
            Name = "ReturnForm";
            Text = "ReturnForm";
            Load += ReturnForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReturnTitle;
        private Label lblRentalId;
        private TextBox txtRentalId;
        private Button btnReturnItem;
        private Button btnBack;
    }
}