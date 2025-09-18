namespace SalesManagementSystem.PL.SalesForms
{
    partial class FrmSaleOrder
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
            txtID = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            dgvSalesOrder = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            SalePrice = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            nudQuantity = new NumericUpDown();
            label4 = new Label();
            cbCustomers = new ComboBox();
            label7 = new Label();
            btnDelete = new Button();
            dtpDate = new DateTimePicker();
            label3 = new Label();
            cbProducts = new ComboBox();
            btnSaveOrder = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalesOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
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
            panel1.Size = new Size(1221, 64);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(515, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 0;
            label1.Text = "شاشة المبيعات";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Controls.Add(nudTotalOrder);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 610);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1221, 93);
            panel3.TabIndex = 1;
            // 
            // nudTotalOrder
            // 
            nudTotalOrder.Location = new Point(12, 45);
            nudTotalOrder.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nudTotalOrder.Name = "nudTotalOrder";
            nudTotalOrder.Size = new Size(239, 36);
            nudTotalOrder.TabIndex = 16;
            nudTotalOrder.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(110, 14);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(141, 28);
            label5.TabIndex = 18;
            label5.Text = "اجمالي الفاتورة :";
            // 
            // txtID
            // 
            txtID.Location = new Point(31, 115);
            txtID.Margin = new Padding(2, 3, 2, 3);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(239, 36);
            txtID.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 85);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 4;
            label2.Text = "رقم الفاتور :";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSlateGray;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(786, 285);
            btnAdd.Margin = new Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 35);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "اضافة";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvSalesOrder
            // 
            dgvSalesOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalesOrder.BackgroundColor = Color.MistyRose;
            dgvSalesOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesOrder.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, SalePrice, Column4 });
            dgvSalesOrder.Location = new Point(12, 341);
            dgvSalesOrder.Name = "dgvSalesOrder";
            dgvSalesOrder.RowHeadersWidth = 51;
            dgvSalesOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalesOrder.Size = new Size(1197, 263);
            dgvSalesOrder.TabIndex = 13;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "رقم الصنف";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "اسم الصنف";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Quantity";
            Column3.HeaderText = "الكمية";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // SalePrice
            // 
            SalePrice.DataPropertyName = "SalePrice";
            SalePrice.HeaderText = "سعر البيع";
            SalePrice.MinimumWidth = 6;
            SalePrice.Name = "SalePrice";
            // 
            // Column4
            // 
            Column4.HeaderText = "الاجمالي";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(618, 284);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(137, 36);
            nudQuantity.TabIndex = 15;
            nudQuantity.TextAlign = HorizontalAlignment.Center;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(383, 87);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 17;
            label4.Text = "التاريخ :";
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(751, 118);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(247, 36);
            cbCustomers.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(751, 88);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(73, 28);
            label7.TabIndex = 21;
            label7.Text = "العميل :";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkSlateGray;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(910, 285);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 35);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(383, 118);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(247, 36);
            dtpDate.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(298, 254);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 24;
            label3.Text = "الاصناف :";
            // 
            // cbProducts
            // 
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(298, 284);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(314, 36);
            cbProducts.TabIndex = 23;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.BackColor = Color.DarkSlateGray;
            btnSaveOrder.ForeColor = Color.White;
            btnSaveOrder.Location = new Point(1021, 115);
            btnSaveOrder.Margin = new Padding(2, 3, 2, 3);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(177, 36);
            btnSaveOrder.TabIndex = 25;
            btnSaveOrder.Text = "حفظ الفاتورة";
            btnSaveOrder.UseVisualStyleBackColor = false;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // FrmSaleOrder
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1221, 703);
            Controls.Add(btnSaveOrder);
            Controls.Add(label3);
            Controls.Add(cbProducts);
            Controls.Add(dtpDate);
            Controls.Add(label7);
            Controls.Add(cbCustomers);
            Controls.Add(label4);
            Controls.Add(nudQuantity);
            Controls.Add(dgvSalesOrder);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmSaleOrder";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة المبيعات";
            Load += FrmCatgory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalesOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private TextBox txtID;
        private Label label2;
        private Button btnAdd;
        private DataGridView dgvSalesOrder;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudTotalOrder;
        private Label label4;
        private Label label5;
        private ComboBox cbCustomers;
        private Label label7;
        private Button btnDelete;
        private DateTimePicker dtpDate;
        private Label label3;
        private ComboBox cbProducts;
        private Button btnSaveOrder;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn SalePrice;
        private DataGridViewTextBoxColumn Column4;
    }
}