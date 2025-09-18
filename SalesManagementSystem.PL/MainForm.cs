using SalesManagementSystem.PL.SalesForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.PL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCatgory frmCatgory = new FrmCatgory();
            frmCatgory.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProduct frmProduct = new FrmProduct();
            frmProduct.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSaleOrder frmSaleOrder = new FrmSaleOrder();
            frmSaleOrder.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSaleOrderReport frm = new FrmSaleOrderReport();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmStock frmStock = new FrmStock();
            frmStock.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer();    
            frmCustomer.ShowDialog();
        }
    }
}
