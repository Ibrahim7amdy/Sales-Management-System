using SalesManagementSystem.BLL.Services;
using SalesManagementSystem.DAL.Models;

namespace SalesManagementSystem.PL.SalesForms
{
    public partial class FrmCatgory : Form
    {
        public FrmCatgory()
        {
            InitializeComponent();
        }
        private bool ValidationInputs()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("من فضلك ادخل رقم المجموعة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم المجموعة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم المجموعة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Category category = new Category()
            {
                Name = txtName.Text
            };

            bool IsAdded = CategoryService.AddCategory(category);

            if (IsAdded)
            {
                MessageBox.Show("تمت الاضافة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم تتم الاضافة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadCategories();

        }
        private void LoadCategories()
        {
            var categories = CategoryService.GetAllCategorys();
            dgvCategory.DataSource = categories;
        }
        private void FrmCatgory_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;

            LoadCategories();
        }

        private void dgvCategory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisableWhenEditOrDelete();

            txtID.Text = dgvCategory.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvCategory.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DisableWhenEditOrDelete();

            if (!ValidationInputs())
            {
                return;
            }

            Category category = new Category
            {
                ID = int.Parse(txtID.Text),
                Name = txtName.Text
            };

            bool IsUpdated = CategoryService.UpdateCategory(category);
            if (IsUpdated)
            {
                MessageBox.Show("تم التعديل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم يتم التعديل", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadCategories();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DisableWhenEditOrDelete();

            if (MessageBox.Show("هل انتا متأكد من حذف هذه المجموعة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool IsDeleted = CategoryService.DeleteCategory(int.Parse(txtID.Text));
                if (IsDeleted)
                {
                    MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadCategories();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DisableWhenEditOrDelete();
            if (MessageBox.Show("هل انتا متأكد من حذف جميع المجموعات؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool IsAllDeleted = CategoryService.DeleteAllCategory();

                if (IsAllDeleted)
                {
                    MessageBox.Show("تم حذف الكل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadCategories();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Category> categories = CategoryService.GetAllCategorysByPattern(txtSearch.Text);
            dgvCategory.DataSource = categories;
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
