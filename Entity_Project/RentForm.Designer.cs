namespace Entity_Project
{
    partial class RentForm
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
            lblItemName = new Label();
            lblDisplayItemName = new Label();
            lblDays = new Label();
            lblDisplayTotal = new Label();
            lblPricePerDay = new Label();
            lblDisplayPrice = new Label();
            lblTotalPrice = new Label();
            txtDays = new TextBox();
            btnConfirmRent = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(300, 44);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(78, 15);
            lblItemName.TabIndex = 0;
            lblItemName.Text = "Selected Item";
            // 
            // lblDisplayItemName
            // 
            lblDisplayItemName.AutoSize = true;
            lblDisplayItemName.Location = new Point(422, 44);
            lblDisplayItemName.Name = "lblDisplayItemName";
            lblDisplayItemName.Size = new Size(38, 15);
            lblDisplayItemName.TabIndex = 1;
            lblDisplayItemName.Text = "label2";
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(300, 108);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(68, 15);
            lblDays.TabIndex = 2;
            lblDays.Text = "Rental Days";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Location = new Point(422, 235);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(38, 15);
            lblDisplayTotal.TabIndex = 3;
            lblDisplayTotal.Text = "label4";
            // 
            // lblPricePerDay
            // 
            lblPricePerDay.AutoSize = true;
            lblPricePerDay.Location = new Point(300, 172);
            lblPricePerDay.Name = "lblPricePerDay";
            lblPricePerDay.Size = new Size(76, 15);
            lblPricePerDay.TabIndex = 4;
            lblPricePerDay.Text = "Price Per Day";
            // 
            // lblDisplayPrice
            // 
            lblDisplayPrice.AutoSize = true;
            lblDisplayPrice.Location = new Point(422, 172);
            lblDisplayPrice.Name = "lblDisplayPrice";
            lblDisplayPrice.Size = new Size(38, 15);
            lblDisplayPrice.TabIndex = 5;
            lblDisplayPrice.Text = "label6";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(300, 235);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(61, 15);
            lblTotalPrice.TabIndex = 6;
            lblTotalPrice.Text = "Total Price";
            // 
            // txtDays
            // 
            txtDays.Location = new Point(404, 108);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(100, 23);
            txtDays.TabIndex = 7;
            txtDays.TextChanged += txtDays_TextChanged;
            // 
            // btnConfirmRent
            // 
            btnConfirmRent.Location = new Point(249, 322);
            btnConfirmRent.Name = "btnConfirmRent";
            btnConfirmRent.Size = new Size(75, 23);
            btnConfirmRent.TabIndex = 8;
            btnConfirmRent.Text = "Confirm Rent";
            btnConfirmRent.UseVisualStyleBackColor = true;
            btnConfirmRent.Click += btnConfirmRent_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(460, 322);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // RentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirmRent);
            Controls.Add(txtDays);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblDisplayPrice);
            Controls.Add(lblPricePerDay);
            Controls.Add(lblDisplayTotal);
            Controls.Add(lblDays);
            Controls.Add(lblDisplayItemName);
            Controls.Add(lblItemName);
            Name = "RentForm";
            Text = "RentForm";
            Load += RentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemName;
        private Label lblDisplayItemName;
        private Label lblDays;
        private Label lblDisplayTotal;
        private Label lblPricePerDay;
        private Label lblDisplayPrice;
        private Label lblTotalPrice;
        private TextBox txtDays;
        private Button btnConfirmRent;
        private Button btnCancel;
    }
}