using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DAL.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double BuyPrice { get; set; }
        public double SalePrice { get; set; }
        public double Quantity { get; set; }
        public int CategoryID { get; set; }
    }
}
