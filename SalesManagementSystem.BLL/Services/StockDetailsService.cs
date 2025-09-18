using SalesManagementSystem.DAL.Models;
using SalesManagementSystem.DAL;
using System.Data;

namespace SalesManagementSystem.BLL.Services
{
    public static class StockDetailsService
    {
        //GetAllStockDetailss
        //public static List<StockDetails> GetAllStockDetailss()
        //{
        //    var dataTable = DatabaseHelper.ExecuteSelect("SELECT * FROM StockDetails");
        //    List<StockDetails> StockDetailss = new List<StockDetails>();
        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        StockDetailss.Add(new StockDetails
        //        {
        //            ID = Convert.ToInt32(row["ID"]),
        //            Name = row["Name"].ToString(),
        //        });
        //    }
        //    return StockDetailss;
        //}

        //public static List<StockDetails> GetAllStockDetailssByPattern(string Pattern)
        //{
        //    var dataTable = DatabaseHelper.ExecuteSelect($"SELECT * FROM StockDetails where Name Like N'%{Pattern}%' ");
        //    List<StockDetails> StockDetailss = new List<StockDetails>();
        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        StockDetailss.Add(new StockDetails
        //        {
        //            ID = Convert.ToInt32(row["ID"]),
        //            Name = row["Name"].ToString(),
        //        });
        //    }
        //    return StockDetailss;
        //}

        //GetStockDetailsByID
        //public static StockDetails? GetStockDetailsByID(int id)
        //{
        //    var dataTable = DatabaseHelper.ExecuteSelect($"SELECT * FROM StockDetailss WHERE ID = {id}");

        //    if (dataTable.Rows.Count == 0)
        //        return null;

        //    var row = dataTable.Rows[0];
        //    return new StockDetails
        //    {
        //        ID = Convert.ToInt32(row["ID"]),
        //        Name = row["Name"].ToString(),
        //    };
        //}

        //AddStockDetails
        public static bool AddStockDetails(StockDetails StockDetails)
        {
            bool Result = DatabaseHelper.ExecuteDML($"INSERT INTO StockDetails (STOCKID,TYPE,TOTAL,DATE,ORDERID) VALUES ({StockDetails.StockID},{(int)StockDetails.Type},{StockDetails.Total},'{StockDetails.Date}',{StockDetails.SaleOrderID})");
            return Result;
        }
        public static string AddStockDetailsGetCommand(StockDetails StockDetails)
        {
            string command = $"INSERT INTO StockDetails (STOCKID,TYPE,TOTAL,DATE,ORDERID) VALUES ({StockDetails.StockID},{(int)StockDetails.Type},{StockDetails.Total},'{StockDetails.Date}',{StockDetails.SaleOrderID})";
            return command;
        }

        ////UpdateStockDetails
        //public static bool UpdateStockDetails(StockDetails StockDetails)
        //{
        //    bool Result = DatabaseHelper.ExecuteDML($"UPDATE StockDetails SET Name = N'{StockDetails.Name}' WHERE ID = {StockDetails.ID}");
        //    return Result;
        //}

        //DeleteStockDetails
        public static bool DeleteStockDetails(int id)
        {
            bool Result = DatabaseHelper.ExecuteDML($"DELETE FROM StockDetails WHERE ID = {id}");
            return Result;
        }

        public static bool DeleteAllStockDetails()
        {
            bool Result = DatabaseHelper.ExecuteDML($"DELETE FROM StockDetails");
            return Result;
        }
    }
}
