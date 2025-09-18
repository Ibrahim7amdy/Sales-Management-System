using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DAL.Models
{
    public class SaleOrderProduct
    {
        public double ProductPrice { get; set; }
        public double ProductQuantity { get; set; }
        public double ProductTotalPrice { get; set; }
        public int ProductID { get; set; }
        public int SaleOrderID { get; set; }
    }
}
