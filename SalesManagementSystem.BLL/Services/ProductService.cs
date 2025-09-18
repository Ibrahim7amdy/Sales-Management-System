using SalesManagementSystem.BLL.Dtos;
using SalesManagementSystem.DAL;
using SalesManagementSystem.DAL.Models;
using System.Data;
using System.Text;

namespace SalesManagementSystem.BLL
{
    public static class ProductService
    {
        //GetAllProducts
        public static List<Product> GetAllProducts()
        {
            var dataTable = DatabaseHelper.ExecuteSelect("SELECT * FROM Products");
            List<Product> products = new List<Product>();
            foreach (DataRow row in dataTable.Rows)
            {
                products.Add(new Product
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Name = row["Name"].ToString(),
                    BuyPrice = Convert.ToDouble(row["BuyPrice"]),
                    SalePrice = Convert.ToDouble(row["SalePrice"]),
                    Quantity = Convert.ToDouble(row["Quantity"]),
                    CategoryID = Convert.ToInt32(row["CategoryID"])
                });
            }
            return products;
        }
        public static List<ProductReadBasicDto> GetAllBasicProducts()
        {
            var dataTable = DatabaseHelper.ExecuteSelect("SELECT ID , NAME FROM Products");
            List<ProductReadBasicDto> products = new List<ProductReadBasicDto>();
            foreach (DataRow row in dataTable.Rows)
            {
                products.Add(new ProductReadBasicDto
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Name = row["Name"].ToString(),
                });
            }
            return products;
        }

        public static List<Product> GetAllProductsByPattern(string Pattern)
        {
            var dataTable = DatabaseHelper.ExecuteSelect($"SELECT * FROM Products where Name Like N'%{Pattern}%' or BuyPrice Like N'%{Pattern}%' or SalePrice Like N'%{Pattern}%' or Quantity Like N'%{Pattern}%'  ");
            List<Product> products = new List<Product>();
            foreach (DataRow row in dataTable.Rows)
            {
                products.Add(new Product
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Name = row["Name"].ToString(),
                    BuyPrice = Convert.ToDouble(row["BuyPrice"]),
                    SalePrice = Convert.ToDouble(row["SalePrice"]),
                    Quantity = Convert.ToDouble(row["Quantity"]),
                    CategoryID = Convert.ToInt32(row["CategoryID"])
                });
            }
            return products;
        }

        //GetProductByID
        public static Product? GetProductByID(int id)
        {
            var dataTable = DatabaseHelper.ExecuteSelect($"SELECT * FROM Products WHERE ID = {id}");

            if (dataTable.Rows.Count == 0)
                return null;

            var row = dataTable.Rows[0];
            return new Product
            {
                ID = Convert.ToInt32(row["ID"]),
                Name = row["Name"].ToString(),
                BuyPrice = Convert.ToDouble(row["BuyPrice"]),
                SalePrice = Convert.ToDouble(row["SalePrice"]),
                Quantity = Convert.ToDouble(row["Quantity"]),
                CategoryID = Convert.ToInt32(row["CategoryID"])
            };
        }

        //AddProduct
        public static bool AddProduct(Product product)
        {
            bool Result = DatabaseHelper.ExecuteDML($"INSERT INTO Products (Name, BuyPrice,SalePrice, Quantity,CategoryID) VALUES ('{product.Name}', {product.BuyPrice}, {product.SalePrice}, {product.Quantity}, {product.CategoryID})");
            return Result;
        }

        //UpdateProduct
        public static bool UpdateProduct(Product product)
        {
            bool Result = DatabaseHelper.ExecuteDML($"UPDATE Products SET Name = '{product.Name}', BuyPrice = {product.BuyPrice}, SalePrice = {product.SalePrice}, Quantity = {product.Quantity} , CategoryID = {product.CategoryID}  WHERE ID = {product.ID}");
            return Result;
        }
        public static bool UpdateProductMinus(List<Product> products)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var product in products)
            {
                stringBuilder.Append($"UPDATE Products SET  Quantity = Quantity - {product.Quantity}  WHERE ID = {product.ID};");
                stringBuilder.Append("\n");
            }
            string cmd = stringBuilder.ToString();
            bool Result = DatabaseHelper.ExecuteDML(cmd);
            return Result;
        }
        public static string UpdateProductMinusGetCommand(List<Product> products)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var product in products)
            {
                stringBuilder.Append($"UPDATE Products SET  Quantity = Quantity - {product.Quantity}  WHERE ID = {product.ID};");
                stringBuilder.Append("\n");
            }

            string command = stringBuilder.ToString();
            return command;
        }
        public static bool UpdateProductPlus(int ID, double Quantity)
        {
            bool Result = DatabaseHelper.ExecuteDML($"UPDATE Products SET  Quantity = Quantity + {Quantity}  WHERE ID = {ID}");
            return Result;
        }
        //DeleteProduct
        public static bool DeleteProduct(int id)
        {
            bool Result = DatabaseHelper.ExecuteDML($"DELETE FROM Products WHERE ID = {id}");
            return Result;
        }

        public static bool DeleteAllProduct()
        {
            bool Result = DatabaseHelper.ExecuteDML($"DELETE FROM Products");
            return Result;
        }
    }
}
