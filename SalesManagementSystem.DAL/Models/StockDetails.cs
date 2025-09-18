using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DAL.Models
{
    public enum Type
    {
        Sale = 1,
        Purchase = 2,
        Expenses = 3
    }
    public class StockDetails
    {
        public int ID { get; set; }
        public double Total { get; set; }
        public DateTime Date { get; set; }
        public Type Type { get; set; }
        public int StockID  { get; set; }
        public int SaleOrderID { get; set; }
    }
}
