using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.BLL.Dtos
{
    public class SaleOrderReadProductDto
    {
        public int SaleOrderID { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public double ProductQuantity { get; set; }
        public double ProductTotalPrice { get; set; }
    }
}
