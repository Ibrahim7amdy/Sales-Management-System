using SalesManagementSystem.BLL.Dtos;
using SalesManagementSystem.BLL.Services;
using SalesManagementSystem.DAL.Models;

namespace SalesManagementSystem.PL.SalesForms
{
    public partial class FrmSaleOrderReport : Form
    {
        public FrmSaleOrderReport()
        {
            InitializeComponent();
        }
        private void FrmSaleOrderReport_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<SaleOrderReadProductDto> saleOrders = SaleOrderService.GetAllSaleOrderDateRange(Convert.ToDateTime(DtpFromDate.Value), Convert.ToDateTime(DtpToDate.Value));
            dgvSalesOrder.DataSource = saleOrders;
            TotalOrders(saleOrders);

        }
        private void btnSearchtxt_Click(object sender, EventArgs e)
        {
            List<SaleOrderReadProductDto> saleOrders = default;
            if (cbByOrderID.Checked)
            {
                saleOrders = SaleOrderService.GetAllSaleOrderWithProducts(default,Convert.ToInt32(txtOrderID.Text));
            }
            else
            {
               saleOrders = SaleOrderService.GetAllSaleOrderWithProducts(Convert.ToString(txtSearchCustomerName.Text),default);
            }
            dgvSalesOrder.DataSource = saleOrders;

            TotalOrders(saleOrders);
        }
        private void TotalOrders(List<SaleOrderReadProductDto> saleOrders)
        {
            foreach (var order in saleOrders)
            {
                nudTotalOrder.Value += Convert.ToDecimal(order.ProductTotalPrice);
            }
        }
    }
}
