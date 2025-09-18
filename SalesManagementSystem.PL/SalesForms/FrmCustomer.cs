using SalesManagementSystem.BLL.Services;
using SalesManagementSystem.DAL.Models;

namespace SalesManagementSystem.PL.SalesForms
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        private bool ValidationInputs()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("من فضلك ادخل رقم العميل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم العميل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("من فضلك ادخل عنوان العميل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                MessageBox.Show("من فضلك ادخل رقم فون العميل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم العميل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("من فضلك ادخل عنوان العميل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                MessageBox.Show("من فضلك ادخل رقم فون العميل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Customer Customer = new Customer()
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                PhoneNumber = txtPhoneNumber.Text,
                BirthDate = dtpBirthDate.Value,
            };

            bool IsAdded = CustomerService.AddCustomer(Customer);

            if (IsAdded)
            {
                MessageBox.Show("تمت الاضافة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم تتم الاضافة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadCustomers();

        }
        private void LoadCustomers()
        {
            var categories = CustomerService.GetAllCustomers();
            dgvCustomer.DataSource = categories;
        }
        private void FrmCatgory_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;

            LoadCustomers();
        }

        private void dgvCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisableWhenEditOrDelete();

            txtID.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            txtPhoneNumber.Text = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
            txtAddress.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DisableWhenEditOrDelete();

            if (!ValidationInputs())
            {
                return;
            }

            Customer Customer = new Customer
            {
                ID = int.Parse(txtID.Text),
                Name = txtName.Text,
                Address = txtAddress.Text,
                PhoneNumber = txtPhoneNumber.Text,
                BirthDate = dtpBirthDate.Value,
            };

            bool IsUpdated = CustomerService.UpdateCustomer(Customer);
            if (IsUpdated)
            {
                MessageBox.Show("تم التعديل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم يتم التعديل", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DisableWhenEditOrDelete();

            if (MessageBox.Show("هل انتا متأكد من حذف هذه العميل ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool IsDeleted = CustomerService.DeleteCustomer(int.Parse(txtID.Text));
                if (IsDeleted)
                {
                    MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadCustomers();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DisableWhenEditOrDelete();
            if (MessageBox.Show("هل انتا متأكد من حذف جميع المجموعات؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool IsAllDeleted = CustomerService.DeleteAllCustomer();

                if (IsAllDeleted)
                {
                    MessageBox.Show("تم حذف الكل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadCustomers();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Customer> categories = CustomerService.GetAllCustomersByPattern(txtSearch.Text);
            dgvCustomer.DataSource = categories;
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
    }
}
