using SalesManagementSystem.DAL.Models;
using SalesManagementSystem.DAL;
using System.Data;
using Microsoft.VisualBasic;
using SalesManagementSystem.BLL.Dtos;

namespace SalesManagementSystem.BLL.Services
{
    public static class SaleOrderService
    {
        public static List<SaleOrderReadProductDto> GetAllSaleOrderWithProducts(string customerName = default , int orderID = default)
        {
            var dataTable = DatabaseHelper.ExecuteSelect($@"
                 SELECT 
                    SO.ID, 
                    C.NAME AS CUSTOMERNAME,
                    P.NAME AS PRODUCTNAME, 
                    SOP.PRODUCTPRICE, 
                    SOP.PRODUCTQUANTITY, 
                    SOP.PRODUCTTOTALPRICE
                FROM SALEORDERS SO
                JOIN CUSTOMERS C ON SO.CUSTOMERID = C.ID
                JOIN SALEORDERPRODUCTS SOP ON SOP.SaleOrderID = SO.ID
                JOIN PRODUCTS P ON P.ID = SOP.PRODUCTID
                WHERE 
                    (
                        --C.NAME LIKE '%'+{customerName}+'%' 
                        --OR 
                        SO.ID = {orderID}
                    );                
                     
                    "
            );

            List<SaleOrderReadProductDto> SaleOrders = new List<SaleOrderReadProductDto>();
            foreach (DataRow row in dataTable.Rows)
            {
                SaleOrders.Add(new SaleOrderReadProductDto
                {
                    SaleOrderID = Convert.ToInt32(row["ID"]),
                    CustomerName = Convert.ToString(row["CUSTOMERNAME"]),
                    ProductName = Convert.ToString(row["PRODUCTNAME"]),
                    ProductPrice = Convert.ToDouble(row["PRODUCTPRICE"]),
                    ProductQuantity = Convert.ToDouble(row["PRODUCTQUANTITY"]),
                    ProductTotalPrice = Convert.ToDouble(row["PRODUCTTOTALPRICE"]),
                });
            }
            return SaleOrders;
        }
        public static List<SaleOrderReadProductDto> GetAllSaleOrderDateRange(DateTime startDate , DateTime endDate)
        {
            var dataTable = DatabaseHelper.ExecuteSelect($@"
                    SELECT 
	                    SO.ID , 
	                    C.NAME AS CUSTOMERNAME,
	                    P.NAME AS PRODUCTNAME , 
	                    SOP.PRODUCTPRICE , 
	                    SO.DATEORDER,
	                    SOP.PRODUCTQUANTITY , 
	                    SOP.PRODUCTTOTALPRICE 
                    FROM 
	                    SALEORDERS AS SO , 
	                    CUSTOMERS AS C ,
	                    PRODUCTS AS P , 
	                    SALEORDERPRODUCTS AS SOP 
                    WHERE 
	                    SO.CUSTOMERID = C.ID  AND 
	                    P.ID = SOP.PRODUCTID AND 
	                    SOP.SaleOrderID = SO.ID AND
	                    SO.DATEORDER  Between '{startDate}' and  '{endDate}'       
                    "
            );

            List<SaleOrderReadProductDto> SaleOrders = new List<SaleOrderReadProductDto>();
            foreach (DataRow row in dataTable.Rows)
            {
                SaleOrders.Add(new SaleOrderReadProductDto
                {
                    SaleOrderID = Convert.ToInt32(row["ID"]),
                    CustomerName = Convert.ToString(row["CUSTOMERNAME"]),
                    ProductName = Convert.ToString(row["PRODUCTNAME"]),
                    ProductPrice = Convert.ToDouble(row["PRODUCTPRICE"]),
                    ProductQuantity = Convert.ToDouble(row["PRODUCTQUANTITY"]),
                    ProductTotalPrice = Convert.ToDouble(row["PRODUCTTOTALPRICE"]),
                });
            }
            return SaleOrders;
        }
        //GetAllSaleOrders
        public static List<SaleOrder> GetAllSaleOrders()
        {
            var dataTable = DatabaseHelper.ExecuteSelect("SELECT * FROM SaleOrders");
            List<SaleOrder> SaleOrders = new List<SaleOrder>();
            foreach (DataRow row in dataTable.Rows)
            {
                SaleOrders.Add(new SaleOrder
                {
                    ID = Convert.ToInt32(row["ID"]),
                    //Name = row["Name"].ToString(),
                });
            }
            return SaleOrders;
        }
        public static int GetLastOrderID()
        {
            var dataTable = DatabaseHelper.ExecuteSelect("SELECT ISNULL(MAX(ID), 0) AS LastOrderID FROM SaleOrders");

            var row = dataTable.Rows[0];

            return  (int)row["LastOrderID"];
        }

        public static List<SaleOrder> GetAllSaleOrdersByPattern(string Pattern)
        {
            var dataTable = DatabaseHelper.ExecuteSelect($"SELECT * FROM SaleOrders where Name Like N'%{Pattern}%' ");
            List<SaleOrder> SaleOrders = new List<SaleOrder>();
            foreach (DataRow row in dataTable.Rows)
            {
                SaleOrders.Add(new SaleOrder
                {
                    ID = Convert.ToInt32(row["ID"]),
                    //Name = row["Name"].ToString(),
                });
            }
            return SaleOrders;
        }

        //GetSaleOrderByID
        public static SaleOrder? GetSaleOrderByID(int id)
        {
            var dataTable = DatabaseHelper.ExecuteSelect($"SELECT * FROM SaleOrders WHERE ID = {id}");

            if (dataTable.Rows.Count == 0)
                return null;

            var row = dataTable.Rows[0];
            return new SaleOrder
            {
                ID = Convert.ToInt32(row["ID"]),
                //Name = row["Name"].ToString(),
            };
        }

        //AddSaleOrder
        public static bool AddSaleOrder(SaleOrder SaleOrder)
        {
            bool Result = DatabaseHelper.ExecuteDML($"INSERT INTO SaleOrders (ID,DATEORDER,CUSTOMERID,TOTALORDER) VALUES ({SaleOrder.ID},'{SaleOrder.DateOrder}',{SaleOrder.CustomerID},{SaleOrder.TotalOrder})");
            return Result;
        }
        public static string AddSaleOrderGetCommand(SaleOrder SaleOrder)
        {
            string command = $"INSERT INTO SaleOrders (ID,DATEORDER,CUSTOMERID,TOTALORDER) VALUES ({SaleOrder.ID},'{SaleOrder.DateOrder}',{SaleOrder.CustomerID},{SaleOrder.TotalOrder})";
            return command;
        }

        public static bool InsertSaleOrderTransaction(
            SaleOrder saleOrder,
            List<SaleOrderProduct> saleOrderProducts,
            List<Product> products ,
            Stock stock,
            StockDetails stockDetails
        )
        {
            List<string> commands = new List<string>();

            //Insert SaleOrders
            string addSaleOrderCommand = SaleOrderService.AddSaleOrderGetCommand(saleOrder);
            commands.Add(addSaleOrderCommand);

            //Insert SaleOrderProducts
            string addSaleOrderProductCommand = SaleOrderProductService.AddSaleOrderProductGetCommand(saleOrderProducts);
            commands.Add(addSaleOrderProductCommand);

            //Update Product Quantitys -
            string updateProductMinusCommand = ProductService.UpdateProductMinusGetCommand(products);
            commands.Add(updateProductMinusCommand);

            //Update Stock Money +
            string updateStockMoneyPlusCommand = StockService.UpdateStockMoneyPlusGetCommand(stock);
            commands.Add(updateStockMoneyPlusCommand);

            //Insert StockDetails 
            string addStockDetailsCommand = StockDetailsService.AddStockDetailsGetCommand(stockDetails);
            commands.Add(addStockDetailsCommand);

            bool result = DatabaseHelper.ExecuteTransaction(commands);

            return result;
        }

        //UpdateSaleOrder
        //public static bool UpdateSaleOrder(SaleOrder SaleOrder)
        //{
        //    bool Result = DatabaseHelper.ExecuteDML($"UPDATE SaleOrders SET Name = N'{SaleOrder.Name}' WHERE ID = {SaleOrder.ID}");
        //    return Result;
        //}

        //DeleteSaleOrder
        public static bool DeleteSaleOrder(int id)
        {
            bool Result = DatabaseHelper.ExecuteDML($"DELETE FROM SaleOrders WHERE ID = {id}");
            return Result;
        }

        public static bool DeleteAllSaleOrder()
        {
            bool Result = DatabaseHelper.ExecuteDML($"DELETE FROM SaleOrders");
            return Result;
        }
    }
}
