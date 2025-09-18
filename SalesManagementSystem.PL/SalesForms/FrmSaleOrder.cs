using SalesManagementSystem.BLL;
using SalesManagementSystem.BLL.Dtos;
using SalesManagementSystem.BLL.Services;
using SalesManagementSystem.DAL.Models;
using System.Transactions;
using Type = SalesManagementSystem.DAL.Models.Type;

namespace SalesManagementSystem.PL.SalesForms
{
    public partial class FrmSaleOrder : Form
    {
        public FrmSaleOrder()
        {
            InitializeComponent();
        }
        private void FrmCatgory_Load(object sender, EventArgs e)
        {
            List<ProductReadBasicDto> products = ProductService.GetAllBasicProducts();
            cbProducts.DataSource = products;
            cbProducts.DisplayMember = "Name";
            cbProducts.ValueMember = "ID";

            List<CustomerReadBasicDto> customers = CustomerService.GetAllBasicCustomers();
            cbCustomers.DataSource = customers;
            cbCustomers.DisplayMember = "Name";
            cbCustomers.ValueMember = "ID";

             txtID.Text = (SaleOrderService.GetLastOrderID() + 1).ToString();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = ProductService.GetProductByID(Convert.ToInt32(cbProducts.SelectedValue));
            if (product != null)
            {
                
                decimal quantity = Convert.ToDecimal(nudQuantity.Value);
                if(quantity > Convert.ToDecimal( product.Quantity))
                {
                    MessageBox.Show("الكمية المتوفرة من هذا الصنف اقل من المرد بيعها ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    return;
                }
                decimal lineTotal = quantity * Convert.ToDecimal(product.SalePrice);

                // Add row
                dgvSalesOrder.Rows.Add(
                    product.ID,
                    product.Name,
                    quantity,
                    product.SalePrice,
                    lineTotal
                );

                // Update total order
                nudTotalOrder.Value += lineTotal;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انتا متأكد من حذف هذه الصنف؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dgvSalesOrder.CurrentRow.Cells[0].Value != null)
                {
                    int index = dgvSalesOrder.CurrentRow.Index;
                    decimal lineTotal = Convert.ToDecimal(dgvSalesOrder.Rows[index].Cells[4].Value);

                    // Remove the row
                    dgvSalesOrder.Rows.RemoveAt(index);

                    // Update the total
                    nudTotalOrder.Value -= lineTotal;
                }
            }
        }
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (dgvSalesOrder.Rows.Count > 1)
            {
                //Insert SaleOrder
                SaleOrder saleOrder = new SaleOrder
                {
                    ID = Convert.ToInt32(txtID.Text),
                    CustomerID = (int)cbCustomers.SelectedValue,
                    DateOrder = dtpDate.Value,
                    TotalOrder = Convert.ToDouble(nudTotalOrder.Value)
                };
                //Insert SaleOrderProduct

                List<SaleOrderProduct> saleOrderProducts = new List<SaleOrderProduct>();

                for (int i = 0; i < dgvSalesOrder.Rows.Count - 1; i++)
                {
                    saleOrderProducts.Add(new SaleOrderProduct
                    {
                        ProductID = (int)dgvSalesOrder.Rows[i].Cells[0].Value,
                        ProductQuantity = Convert.ToDouble(dgvSalesOrder.Rows[i].Cells[2].Value),
                        ProductPrice = Convert.ToDouble(dgvSalesOrder.Rows[i].Cells[3].Value),
                        ProductTotalPrice = Convert.ToDouble(dgvSalesOrder.Rows[i].Cells[4].Value),
                        SaleOrderID = Convert.ToInt32(txtID.Text),
                    });
                }
                //Update Product
                List<Product> products = new List<Product>();

                for (int i = 0; i < dgvSalesOrder.Rows.Count - 1; i++)
                {
                    products.Add(new Product
                    {
                        ID = (int)dgvSalesOrder.Rows[i].Cells[0].Value,
                        Quantity = Convert.ToDouble(dgvSalesOrder.Rows[i].Cells[2].Value),
                    });
                }
                //Update Stock
                Stock stock = new Stock
                {
                    ID = 1,
                    TotalMoney = Convert.ToDouble(nudTotalOrder.Value)
                };
                //Insert StockDetails
                StockDetails stockDetails = new StockDetails
                {
                    StockID = 1,
                    SaleOrderID = Convert.ToInt32(txtID.Text),
                    Date = dtpDate.Value,
                    Total = Convert.ToDouble(nudQuantity.Value),
                    Type = Type.Sale,
                };

                bool IsSaleOrderInserted = SaleOrderService
                    .InsertSaleOrderTransaction(
                        saleOrder,
                        saleOrderProducts,
                        products,
                        stock,
                        stockDetails
                     );

                if (IsSaleOrderInserted)
                {
                    MessageBox.Show("تم حفظ الفاتورة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("لم يتم حفظ الفاتورة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ////Insert SaleOrders
                //bool IsSaleOrderInserted = SaleOrderService.AddSaleOrder
                //    (new SaleOrder
                //    {
                //        ID = Convert.ToInt32(txtID.Text),
                //        CustomerID = (int)cbCustomers.SelectedValue,
                //        DateOrder = dtpDate.Value,
                //        TotalOrder = Convert.ToDouble(nudTotalOrder.Value)
                //    }
                //    );

                ////Insert SaleOrderProducts
                //List<SaleOrderProduct> saleOrderProducts = new List<SaleOrderProduct>();

                //for (int i = 0; i < dgvSalesOrder.Rows.Count - 1; i++)
                //{
                //    saleOrderProducts.Add(new SaleOrderProduct
                //    {
                //        ProductID = (int)dgvSalesOrder.Rows[i].Cells[0].Value,
                //        ProductQuantity = Convert.ToDouble(dgvSalesOrder.Rows[i].Cells[2].Value),
                //        ProductPrice = Convert.ToDouble(dgvSalesOrder.Rows[i].Cells[3].Value),
                //        ProductTotalPrice = Convert.ToDouble(dgvSalesOrder.Rows[i].Cells[4].Value),
                //        SaleOrderID = SaleOrderService.GetLastOrderID(),
                //    });
                //}
                //bool IsSaleOrderProductsInserted = SaleOrderProductService.AddSaleOrderProduct(saleOrderProducts);

                ////Update Product Quantitys -
                //List<Product> products = new List<Product>();

                //for (int i = 0; i < dgvSalesOrder.Rows.Count - 1; i++)
                //{
                //    products.Add(new Product
                //    {
                //        ID = (int)dgvSalesOrder.Rows[i].Cells[0].Value,
                //        Quantity = Convert.ToDouble(dgvSalesOrder.Rows[i].Cells[2].Value),
                //    });
                //}
                //bool IsProductQuantityUpdated = ProductService.UpdateProductMinus(products);

                ////Update Stock Money +
                //bool IsStockMoneyUpdated = StockService.UpdateStockMoneyPlus(new Stock
                //{
                //    ID = 1,
                //    TotalMoney = Convert.ToDouble(nudTotalOrder.Value)
                //});

                ////Insert StockDetails 
                //bool IsStockDetialsInserted = StockDetailsService.AddStockDetails(new StockDetails
                //{
                //    StockID = 1,
                //    SaleOrderID = Convert.ToInt32(txtID.Text),
                //    Date = dtpDate.Value,
                //    Total = Convert.ToDouble(nudQuantity.Value),
                //    Type = Type.Sale,
                //});

                //if (IsSaleOrderInserted &&
                //    IsSaleOrderProductsInserted &&
                //    IsProductQuantityUpdated &&
                //    IsStockMoneyUpdated &&
                //    IsStockDetialsInserted)
                //{
                //    MessageBox.Show("تم حفظ الفاتورة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show("لم يتم حفظ الفاتورة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

                dgvSalesOrder.Rows.Clear();
                nudTotalOrder.Value = 0;
                nudQuantity.Value = 1;
                txtID.Text =( SaleOrderService.GetLastOrderID() + 1) .ToString();
            }
        }
    }
}
