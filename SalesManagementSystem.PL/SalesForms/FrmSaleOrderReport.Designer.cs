namespace SalesManagementSystem.PL.SalesForms
{
    partial class FrmSaleOrderReport
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
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            nudTotalOrder = new NumericUpDown();
            label5 = new Label();
            btnSearchDate = new Button();
            DtpToDate = new DateTimePicker();
            DtpFromDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dgvSalesOrder = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            SalePrice = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnSearchtxt = new Button();
            txtSearchCustomerName = new TextBox();
            label4 = new Label();
            txtOrderID = new TextBox();
            label6 = new Label();
            cbByOrderID = new CheckBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalesOrder).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1303, 64);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(550, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 0;
            label1.Text = "شاشة تقارير المبيعات ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Controls.Add(nudTotalOrder);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 570);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1303, 90);
            panel3.TabIndex = 1;
            // 
            // nudTotalOrder
            // 
            nudTotalOrder.Location = new Point(12, 42);
            nudTotalOrder.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nudTotalOrder.Name = "nudTotalOrder";
            nudTotalOrder.Size = new Size(239, 36);
            nudTotalOrder.TabIndex = 19;
            nudTotalOrder.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(110, 11);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(141, 28);
            label5.TabIndex = 20;
            label5.Text = "اجمالي الفاتورة :";
            // 
            // btnSearchDate
            // 
            btnSearchDate.BackColor = Color.DarkSlateGray;
            btnSearchDate.ForeColor = Color.White;
            btnSearchDate.Location = new Point(230, 108);
            btnSearchDate.Margin = new Padding(2, 3, 2, 3);
            btnSearchDate.Name = "btnSearchDate";
            btnSearchDate.Size = new Size(141, 35);
            btnSearchDate.TabIndex = 11;
            btnSearchDate.Text = "بحث";
            btnSearchDate.UseVisualStyleBackColor = false;
            btnSearchDate.Click += btnSearch_Click;
            // 
            // DtpToDate
            // 
            DtpToDate.Format = DateTimePickerFormat.Short;
            DtpToDate.Location = new Point(773, 108);
            DtpToDate.Name = "DtpToDate";
            DtpToDate.Size = new Size(230, 36);
            DtpToDate.TabIndex = 14;
            // 
            // DtpFromDate
            // 
            DtpFromDate.Format = DateTimePickerFormat.Short;
            DtpFromDate.Location = new Point(485, 108);
            DtpFromDate.Name = "DtpFromDate";
            DtpFromDate.Size = new Size(230, 36);
            DtpFromDate.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(485, 77);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 16;
            label2.Text = "من تاريخ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(773, 77);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 17;
            label3.Text = "الي تاريخ :";
            // 
            // dgvSalesOrder
            // 
            dgvSalesOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalesOrder.BackgroundColor = Color.MistyRose;
            dgvSalesOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesOrder.Columns.AddRange(new DataGridViewColumn[] { Column1, Column5, Column2, Column3, SalePrice, Column4 });
            dgvSalesOrder.Location = new Point(12, 226);
            dgvSalesOrder.Name = "dgvSalesOrder";
            dgvSalesOrder.RowHeadersWidth = 51;
            dgvSalesOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalesOrder.Size = new Size(1279, 338);
            dgvSalesOrder.TabIndex = 18;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "SaleOrderID";
            Column1.HeaderText = "رقم الفاتورة";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "CUSTOMERNAME";
            Column5.HeaderText = "اسم العميل";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "ProductName";
            Column2.HeaderText = "اسم الصنف";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "ProductQuantity";
            Column3.HeaderText = "الكمية";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // SalePrice
            // 
            SalePrice.DataPropertyName = "ProductPrice";
            SalePrice.HeaderText = "سعر البيع";
            SalePrice.MinimumWidth = 6;
            SalePrice.Name = "SalePrice";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "ProductTotalPrice";
            Column4.HeaderText = "الاجمالي";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // btnSearchtxt
            // 
            btnSearchtxt.BackColor = Color.DarkSlateGray;
            btnSearchtxt.ForeColor = Color.White;
            btnSearchtxt.Location = new Point(230, 185);
            btnSearchtxt.Margin = new Padding(2, 3, 2, 3);
            btnSearchtxt.Name = "btnSearchtxt";
            btnSearchtxt.Size = new Size(141, 35);
            btnSearchtxt.TabIndex = 19;
            btnSearchtxt.Text = "بحث";
            btnSearchtxt.UseVisualStyleBackColor = false;
            btnSearchtxt.Click += btnSearchtxt_Click;
            // 
            // txtSearchCustomerName
            // 
            txtSearchCustomerName.Location = new Point(773, 184);
            txtSearchCustomerName.Name = "txtSearchCustomerName";
            txtSearchCustomerName.Size = new Size(230, 36);
            txtSearchCustomerName.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(485, 154);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 21;
            label4.Text = "رقم الفاتورة :";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(485, 184);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(230, 36);
            txtOrderID.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(773, 153);
            label6.Name = "label6";
            label6.Size = new Size(109, 28);
            label6.TabIndex = 23;
            label6.Text = "اسم العميل :";
            // 
            // cbByOrderID
            // 
            cbByOrderID.AutoSize = true;
            cbByOrderID.Location = new Point(461, 194);
            cbByOrderID.Name = "cbByOrderID";
            cbByOrderID.Size = new Size(18, 17);
            cbByOrderID.TabIndex = 24;
            cbByOrderID.UseVisualStyleBackColor = true;
            // 
            // FrmSaleOrderReport
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1303, 660);
            Controls.Add(cbByOrderID);
            Controls.Add(label6);
            Controls.Add(txtOrderID);
            Controls.Add(label4);
            Controls.Add(txtSearchCustomerName);
            Controls.Add(btnSearchtxt);
            Controls.Add(dgvSalesOrder);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DtpFromDate);
            Controls.Add(DtpToDate);
            Controls.Add(btnSearchDate);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmSaleOrderReport";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة تقارير المبيعات ";
            Load += FrmSaleOrderReport_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalesOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Button btnSearchDate;
        private DateTimePicker DtpToDate;
        private DateTimePicker DtpFromDate;
        private Label label2;
        private Label label3;
        private DataGridView dgvSalesOrder;
        private Button btnSearchtxt;
        private TextBox txtSearchCustomerName;
        private Label label4;
        private NumericUpDown nudTotalOrder;
        private Label label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn SalePrice;
        private DataGridViewTextBoxColumn Column4;
        private TextBox txtOrderID;
        private Label label6;
        private CheckBox cbByOrderID;
    }
}