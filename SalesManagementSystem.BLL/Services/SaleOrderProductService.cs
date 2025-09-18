using SalesManagementSystem.DAL.Models;
using SalesManagementSystem.DAL;
using System.Data;
using System.Text;

namespace SalesManagementSystem.BLL.Services
{
    public static class SaleOrderProductService
    {
        //GetAllSaleOrderProducts
        //public static List<SaleOrderProduct> GetAllSaleOrderProducts()
        //{
        //    var dataTable = DatabaseHelper.ExecuteSelect("SELECT * FROM SaleOrderProducts");
        //    List<SaleOrderProduct> SaleOrderProducts = new List<SaleOrderProduct>();
        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        SaleOrderProducts.Add(new SaleOrderProduct
        //        {
        //            ID = Convert.ToInt32(row["ID"]),
        //            Name = row["Name"].ToString(),
        //        });
        //    }
        //    return SaleOrderProducts;
        //}

        //public static List<SaleOrderProduct> GetAllSaleOrderProductsByPattern(string Pattern)
        //{
        //    var dataTable = DatabaseHelper.ExecuteSelect($"SELECT * FROM SaleOrderProducts where Name Like N'%{Pattern}%' ");
        //    List<SaleOrderProduct> SaleOrderProducts = new List<SaleOrderProduct>();
        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        SaleOrderProducts.Add(new SaleOrderProduct
        //        {
        //            ID = Convert.ToInt32(row["ID"]),
        //            Name = row["Name"].ToString(),
        //        });
        //    }
        //    return SaleOrderProducts;
        //}

        //GetSaleOrderProductByID
        //public static SaleOrderProduct? GetSaleOrderProductByID(int id)
        //{
        //    var dataTable = DatabaseHelper.ExecuteSelect($"SELECT * FROM SaleOrderProducts WHERE ID = {id}");

        //    if (dataTable.Rows.Count == 0)
        //        return null;

        //    var row = dataTable.Rows[0];
        //    return new SaleOrderProduct
        //    {
        //        ID = Convert.ToInt32(row["ID"]),
        //        Name = row["Name"].ToString(),
        //    };
        //}

        //AddSaleOrderProduct
        public static bool AddSaleOrderProduct(List<SaleOrderProduct> SaleOrderProducts)
        {
            StringBuilder stringBuilder = new StringBuilder();  

            foreach (var product in SaleOrderProducts)
            {
                stringBuilder.Append($"({product.ProductPrice},{product.ProductQuantity},{product.ProductTotalPrice},{product.SaleOrderID},{product.ProductID}),");
                //stringBuilder.Append("\n");
            }
            string command = stringBuilder.ToString().TrimEnd(',');
            string cmd = $"INSERT INTO SaleOrderProducts (ProductPrice,ProductQuantity,ProductTotalPrice,SaleOrderID,ProductID) VALUES {command}";
            bool Result = DatabaseHelper.ExecuteDML(cmd);
            return Result;
        }
        public static string AddSaleOrderProductGetCommand(List<SaleOrderProduct> SaleOrderProducts)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var product in SaleOrderProducts)
            {
                stringBuilder.Append($"({product.ProductPrice},{product.ProductQuantity},{product.ProductTotalPrice},{product.SaleOrderID},{product.ProductID}),");
                //stringBuilder.Append("\n");
            }
            string cmd = stringBuilder.ToString().TrimEnd(',');

            string command = $"INSERT INTO SaleOrderProducts (ProductPrice,ProductQuantity,ProductTotalPrice,SaleOrderID,ProductID) VALUES {cmd}";
            return command;
        }

        //UpdateSaleOrderProduct
        //public static bool UpdateSaleOrderProduct( SaleOrderProduct SaleOrderProduct)
        //{
        //    bool Result = DatabaseHelper.ExecuteDML($"UPDATE SaleOrderProducts SET Name = N'{SaleOrderProduct.Name}' WHERE ID = {SaleOrderProduct.ID}");
        //    return Result;
        //}

        //DeleteSaleOrderProduct
        public static bool DeleteSaleOrderProduct(int id)
        {
            bool Result = DatabaseHelper.ExecuteDML($"DELETE FROM SaleOrderProducts WHERE ID = {id}");
            return Result;
        }

        public static bool DeleteAllSaleOrderProduct()
        {
            bool Result = DatabaseHelper.ExecuteDML($"DELETE FROM SaleOrderProducts");
            return Result;
        }
    }
}
