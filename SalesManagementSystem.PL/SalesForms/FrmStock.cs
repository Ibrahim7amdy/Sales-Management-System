using SalesManagementSystem.BLL.Services;
using SalesManagementSystem.DAL.Models;

namespace SalesManagementSystem.PL.SalesForms
{
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }
        private bool ValidationInputs()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("من فضلك ادخل رقم الخزنة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم الخزنة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (nudMoney.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل مبلغ الخزنة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم الخزنة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nudMoney.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل مبلغ الخزنة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Stock Stock = new Stock()
            {
                Name = txtName.Text,
                TotalMoney = Convert.ToDouble(nudMoney.Value)
            };

            bool IsAdded = StockServiceDapper.AddStock(Stock);

            if (IsAdded)
            {
                MessageBox.Show("تمت الاضافة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم تتم الاضافة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Loadstocks();

        }
        private void Loadstocks()
        {
            var stocks = StockServiceDapper.GetAllStocks();
            dgvStock.DataSource = stocks;
        }
        private void FrmCatgory_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;

            Loadstocks();
        }

        private void dgvStock_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisableWhenEditOrDelete();

            txtID.Text = dgvStock.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvStock.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DisableWhenEditOrDelete();

            if (!ValidationInputs())
            {
                return;
            }

            Stock Stock = new Stock
            {
                ID = int.Parse(txtID.Text),
                Name = txtName.Text,
                TotalMoney = Convert.ToDouble(nudMoney.Value)
            };

            bool IsUpdated = StockServiceDapper.UpdateStock(Stock);
            if (IsUpdated)
            {
                MessageBox.Show("تم التعديل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم يتم التعديل", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Loadstocks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DisableWhenEditOrDelete();

            if (MessageBox.Show("هل انتا متأكد من حذف هذه الخزنة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool IsDeleted = StockServiceDapper.DeleteStock(int.Parse(txtID.Text));
                if (IsDeleted)
                {
                    MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Loadstocks();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DisableWhenEditOrDelete();
            if (MessageBox.Show("هل انتا متأكد من حذف جميع المجموعات؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool IsAllDeleted = StockServiceDapper.DeleteAllStock();

                if (IsAllDeleted)
                {
                    MessageBox.Show("تم حذف الكل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Loadstocks();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Stock> stocks = StockServiceDapper.GetAllStocksByPattern(txtSearch.Text);
            dgvStock.DataSource = stocks;
        }
        private void DisableWhenEditOrDelete()
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtID.Text = txtName.Text = txtSearch.Text = string.Empty;
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
