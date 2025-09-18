using SalesManagementSystem.BLL;
using SalesManagementSystem.BLL.Services;
using SalesManagementSystem.DAL.Models;

namespace SalesManagementSystem.PL.SalesForms
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }
        private bool ValidationInputs()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("من فضلك ادخل رقم الصنف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم الصنف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (nudBuyPrice.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل سعر شراء الصنف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (nudSalePrice.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل سعر بيع الصنف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
          
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم الصنف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nudBuyPrice.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل سعر شراء الصنف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return ;
            }
            if (nudSalePrice.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل سعر بيع الصنف", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return ;
            }

            Product Product = new Product()
            {
                Name = txtName.Text,
                BuyPrice = (double)nudBuyPrice.Value,
                SalePrice = (double)nudSalePrice.Value,
                Quantity = (double)nudQuantity.Value,
                CategoryID = (int)cbCategories.SelectedValue,
            };

            bool IsAdded = ProductService.AddProduct(Product);

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
            var categories = ProductService.GetAllProducts();
            dgvProduct.DataSource = categories;
        }
        private void FrmCatgory_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;

            LoadCategories();
            List<Category> categories = CategoryService.GetAllCategorys();
            cbCategories.DataSource = categories;
            cbCategories.DisplayMember = "Name";
            cbCategories.ValueMember = "ID";
        }

        private void dgvProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisableWhenEditOrDelete();

            txtID.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            nudQuantity.Value = Convert.ToDecimal(dgvProduct.CurrentRow.Cells[2].Value);
            nudSalePrice.Value = Convert.ToDecimal(dgvProduct.CurrentRow.Cells[3].Value);

            nudBuyPrice.Value = Convert.ToDecimal(dgvProduct.CurrentRow.Cells[4].Value);
            cbCategories.SelectedValue = dgvProduct.CurrentRow.Cells[5].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DisableWhenEditOrDelete();

            if (!ValidationInputs())
            {
                return;
            }

            Product Product = new Product
            {
                ID = int.Parse(txtID.Text),
                Name = txtName.Text,
                BuyPrice = (double)nudBuyPrice.Value,
                SalePrice = (double)nudSalePrice.Value,
                Quantity = (double)nudQuantity.Value,
                CategoryID = (int)cbCategories.SelectedValue,
            };

            bool IsUpdated = ProductService.UpdateProduct(Product);
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

            if (MessageBox.Show("هل انتا متأكد من حذف هذه الصنف؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool IsDeleted = ProductService.DeleteProduct(int.Parse(txtID.Text));
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
            if (MessageBox.Show("هل انتا متأكد من حذف جميع الاصناف؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool IsAllDeleted = ProductService.DeleteAllProduct();

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
            List<Product> categories = ProductService.GetAllProductsByPattern(txtSearch.Text);
            dgvProduct.DataSource = categories;
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
            nudBuyPrice.Value = 0;
            nudSalePrice.Value = 0;
            nudQuantity.Value = 0;

            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
        }
    }
}
