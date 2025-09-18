namespace SalesManagementSystem.PL.SalesForms
{
    partial class FrmCustomer
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
            dgvCustomer = new DataGridView();
            label4 = new Label();
            txtPhoneNumber = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            dtpBirthDate = new DateTimePicker();
            label6 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
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
            panel1.Size = new Size(1361, 64);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(614, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 0;
            label1.Text = "شاشة العملاء ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 663);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1361, 65);
            panel3.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(293, 102);
            txtName.Margin = new Padding(2, 3, 2, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 36);
            txtName.TabIndex = 2;
            // 
            // txtID
            // 
            txtID.Location = new Point(26, 102);
            txtID.Margin = new Padding(2, 3, 2, 3);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(239, 36);
            txtID.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 72);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 4;
            label2.Text = "رقم العميل :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 72);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 28);
            label3.TabIndex = 5;
            label3.Text = "اسم العميل :";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSlateGray;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(488, 191);
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
            btnUpdate.Location = new Point(645, 191);
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
            btnDelete.Location = new Point(825, 191);
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
            btnDeleteAll.Location = new Point(998, 191);
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
            btnNew.Location = new Point(313, 191);
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
            btnSearch.Location = new Point(736, 261);
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
            txtSearch.Location = new Point(360, 261);
            txtSearch.Margin = new Padding(2, 3, 2, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(351, 36);
            txtSearch.TabIndex = 12;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.BackgroundColor = Color.MistyRose;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvCustomer.Location = new Point(12, 315);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(1337, 342);
            dgvCustomer.TabIndex = 13;
            dgvCustomer.CellMouseClick += dgvCustomer_CellMouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(556, 72);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 28);
            label4.TabIndex = 15;
            label4.Text = "رقم الفون :";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(556, 102);
            txtPhoneNumber.Margin = new Padding(2, 3, 2, 3);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(239, 36);
            txtPhoneNumber.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(826, 72);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 17;
            label5.Text = "عنوان العميل :";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(826, 102);
            txtAddress.Margin = new Padding(2, 3, 2, 3);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(239, 36);
            txtAddress.TabIndex = 16;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(1089, 102);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(247, 36);
            dtpBirthDate.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1089, 71);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 28);
            label6.TabIndex = 23;
            label6.Text = "تاريخ الميلاد :";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "رقم العميل";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "اسم العميل";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "PhoneNumber";
            Column3.HeaderText = "رقم الفون";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Address";
            Column4.HeaderText = "عنوان العميل";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "BirthDate";
            Column5.HeaderText = "تاريخ الميلاد";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1361, 728);
            Controls.Add(dtpBirthDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtPhoneNumber);
            Controls.Add(dgvCustomer);
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
            Name = "FrmCustomer";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شاشة العملاء";
            Load += FrmCatgory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
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
        private DataGridView dgvCustomer;
        private Label label4;
        private TextBox txtPhoneNumber;
        private Label label5;
        private TextBox txtAddress;
        private DateTimePicker dtpBirthDate;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}