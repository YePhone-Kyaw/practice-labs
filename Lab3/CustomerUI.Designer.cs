namespace Lab3
{
    partial class CustomerUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCustomerName = new TextBox();
            lblCustomerName = new Label();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblBillAmount = new Label();
            txtBillAmount = new TextBox();
            btnSave = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(272, 30);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(286, 31);
            txtCustomerName.TabIndex = 0;
            txtCustomerName.TextChanged += textBox1_TextChanged;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(59, 30);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(141, 25);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Customer Name";
            lblCustomerName.Click += label1_Click;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(59, 89);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(132, 25);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "Phone Number";
            lblPhoneNumber.Click += label1_Click_1;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(272, 89);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(286, 31);
            txtPhoneNumber.TabIndex = 2;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(648, 30);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(126, 25);
            lblProductName.TabIndex = 5;
            lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(861, 30);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(286, 31);
            txtProductName.TabIndex = 4;
            // 
            // lblBillAmount
            // 
            lblBillAmount.AutoSize = true;
            lblBillAmount.Location = new Point(648, 98);
            lblBillAmount.Name = "lblBillAmount";
            lblBillAmount.Size = new Size(104, 25);
            lblBillAmount.TabIndex = 7;
            lblBillAmount.Text = "Bill Amount";
            // 
            // txtBillAmount
            // 
            txtBillAmount.Location = new Point(861, 98);
            txtBillAmount.Name = "txtBillAmount";
            txtBillAmount.Size = new Size(286, 31);
            txtBillAmount.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(519, 188);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(178, 41);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 291);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1088, 453);
            dataGridView1.TabIndex = 9;
            // 
            // CustomerUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 816);
            Controls.Add(dataGridView1);
            Controls.Add(btnSave);
            Controls.Add(lblBillAmount);
            Controls.Add(txtBillAmount);
            Controls.Add(lblProductName);
            Controls.Add(txtProductName);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblCustomerName);
            Controls.Add(txtCustomerName);
            Name = "CustomerUI";
            Text = "Customer Management Application";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerName;
        private Label lblCustomerName;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblProductName;
        private TextBox txtProductName;
        private Label lblBillAmount;
        private TextBox txtBillAmount;
        private Button btnSave;
        private DataGridView dataGridView1;
    }
}
