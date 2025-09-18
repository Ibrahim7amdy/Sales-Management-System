namespace SalesManagementSystem.PL.SalesForms
{
    partial class FrmProduct
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
            txtName = new TextBox();
            txtID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnDeleteAll = new Button();
            btnNew = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvProduct = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            SalePrice = new DataGridViewTextBoxColumn();
            BuyPrice = new DataGridViewTextBoxColumn();
            CategoryID = new DataGridViewTextBoxColumn();
            nudQuantity = new NumericUpDown();
            nudSalePrice = new NumericUpDown();
            nudBuyPrice = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbCategories = new ComboBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSalePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBuyPrice).BeginInit();
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
            panel1.Size = new Size(1114, 64);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(436, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 0;
            label1.Text = "شاشة الاصناف";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 610);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1114, 65);
            panel3.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(437, 115);
            txtName.Margin = new Padding(2, 3, 2, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 36);
            txtName.TabIndex = 2;
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
            label2.Size = new Size(104, 28);
            label2.TabIndex = 4;
            label2.Text = "رقم الصنف :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 85);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 5;
            label3.Text = "اسم الصنف :";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSlateGray;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(383, 248);
            btnAdd.Margin = new Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 35);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "اضافة";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkSlateGray;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(540, 248);
            btnUpdate.Margin = new Padding(2, 3, 2, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 35);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "تعديل";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkSlateGray;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(720, 248);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 35);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.DarkSlateGray;
            btnDeleteAll.ForeColor = Color.White;
            btnDeleteAll.Location = new Point(893, 248);
            btnDeleteAll.Margin = new Padding(2, 3, 2, 3);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(131, 35);
            btnDeleteAll.TabIndex = 9;
            btnDeleteAll.Text = "حذف الجميع";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.DarkSlateGray;
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(208, 248);
            btnNew.Margin = new Padding(2, 3, 2, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(136, 35);
            btnNew.TabIndex = 10;
            btnNew.Text = "جديد";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkSlateGray;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(737, 313);
            btnSearch.Margin = new Padding(2, 3, 2, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(99, 35);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(361, 313);
            txtSearch.Margin = new Padding(2, 3, 2, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(351, 36);
            txtSearch.TabIndex = 12;
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.BackgroundColor = Color.MistyRose;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, SalePrice, BuyPrice, CategoryID });
            dgvProduct.Location = new Point(12, 368);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(1090, 236);
            dgvProduct.TabIndex = 13;
            dgvProduct.CellMouseClick += dgvProduct_CellMouseClick;
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
            // BuyPrice
            // 
            BuyPrice.DataPropertyName = "BuyPrice";
            BuyPrice.HeaderText = "سعر الشراء";
            BuyPrice.MinimumWidth = 6;
            BuyPrice.Name = "BuyPrice";
            // 
            // CategoryID
            // 
            CategoryID.DataPropertyName = "CategoryID";
            CategoryID.HeaderText = "المجموعة";
            CategoryID.MinimumWidth = 6;
            CategoryID.Name = "CategoryID";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(787, 118);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(247, 36);
            nudQuantity.TabIndex = 14;
            // 
            // nudSalePrice
            // 
            nudSalePrice.Location = new Point(31, 190);
            nudSalePrice.Name = "nudSalePrice";
            nudSalePrice.Size = new Size(239, 36);
            nudSalePrice.TabIndex = 15;
            // 
            // nudBuyPrice
            // 
            nudBuyPrice.Location = new Point(437, 190);
            nudBuyPrice.Name = "nudBuyPrice";
            nudBuyPrice.Size = new Size(239, 36);
            nudBuyPrice.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(787, 85);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 28);
            label4.TabIndex = 17;
            label4.Text = "الكمية :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(437, 159);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 28);
            label5.TabIndex = 18;
            label5.Text = "سعر الشراء :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 159);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 28);
            label6.TabIndex = 19;
            label6.Text = "سعر البيع :";
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(787, 189);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(247, 36);
            cbCategories.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(787, 159);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(93, 28);
            label7.TabIndex = 21;
            label7.Text = "المجموعة :";
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1114, 675);
            Controls.Add(label7);
            Controls.Add(cbCategories);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(nudBuyPrice);
            Controls.Add(nudSalePrice);
            Controls.Add(nudQuantity);
            Controls.Add(dgvProduct);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnNew);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Droid Arabic Kufi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmProduct";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة الاصناف";
            Load += FrmCatgory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSalePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBuyPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private TextBox txtName;
        private TextBox txtID;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDeleteAll;
        private Button btnNew;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvProduct;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudSalePrice;
        private NumericUpDown nudBuyPrice;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbCategories;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn SalePrice;
        private DataGridViewTextBoxColumn BuyPrice;
        private DataGridViewTextBoxColumn CategoryID;
    }
}