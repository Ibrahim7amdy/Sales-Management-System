using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DAL.Models
{
    public class SaleOrder
    {
        public int ID { get; set; }
        public DateTime DateOrder { get; set; }
        public  double TotalOrder { get; set; }
        public int CustomerID { get; set; }
    }
}
