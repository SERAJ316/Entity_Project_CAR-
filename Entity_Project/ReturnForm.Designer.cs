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
            lblReturnTitle.Location = new Point(271, 87);
            lblReturnTitle.Name = "lblReturnTitle";
            lblReturnTitle.Size = new Size(118, 15);
            lblReturnTitle.TabIndex = 0;
            lblReturnTitle.Text = "Return a Rented Item";
            // 
            // lblRentalId
            // 
            lblRentalId.AutoSize = true;
            lblRentalId.Location = new Point(224, 159);
            lblRentalId.Name = "lblRentalId";
            lblRentalId.Size = new Size(54, 15);
            lblRentalId.TabIndex = 1;
            lblRentalId.Text = "Rental ID";
            // 
            // txtRentalId
            // 
            txtRentalId.Location = new Point(336, 159);
            txtRentalId.Name = "txtRentalId";
            txtRentalId.Size = new Size(100, 23);
            txtRentalId.TabIndex = 2;
            // 
            // btnReturnItem
            // 
            btnReturnItem.Location = new Point(537, 237);
            btnReturnItem.Name = "btnReturnItem";
            btnReturnItem.Size = new Size(115, 23);
            btnReturnItem.TabIndex = 3;
            btnReturnItem.Text = "Return Item";
            btnReturnItem.UseVisualStyleBackColor = true;
            btnReturnItem.Click += btnReturnItem_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(234, 246);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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