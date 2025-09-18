using SalesManagementSystem.DAL.Models;
using SalesManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.BLL.Services
{
    public static class StockServiceDapper
    {
        // GetAllStocks
        public static List<Stock> GetAllStocks()
        {
            var sql = "SELECT * FROM Stocks";
            return DatabaseHelperDapper.Query<Stock>(sql);
        }

        public static List<Stock> GetAllStocksByPattern(string pattern)
        {
            var sql = "SELECT * FROM Stocks WHERE Name LIKE N'%"+pattern+"%'";
            return DatabaseHelperDapper.Query<Stock>(sql);
        }

        // GetStockByID
        public static Stock? GetStockByID(int id)
        {
            var sql = "SELECT * FROM Stocks WHERE ID = "+id+"";
            return DatabaseHelperDapper.QuerySingleOrDefault<Stock>(sql);
        }

        // AddStock
        public static bool AddStock(Stock Stock)
        {
            var sql = "INSERT INTO Stocks (Name,TOTALMONEY) VALUES (N'" + Stock.Name+"',"+Stock.TotalMoney+")";
            return DatabaseHelperDapper.Execute(sql);
        }

        // UpdateStock
        public static bool UpdateStock(Stock Stock)
        {
            var sql = $"UPDATE Stocks SET Name = N'{Stock.Name}' ,TotalMoney = {Stock.TotalMoney} WHERE ID = {Stock.ID}";
            return DatabaseHelperDapper.Execute(sql);
        }

        // DeleteStock
        public static bool DeleteStock(int id)
        {
            var sql = $"DELETE FROM Stocks WHERE ID = {id}";
            return DatabaseHelperDapper.Execute(sql);
        }

        public static bool DeleteAllStock()
        {
            var sql = "DELETE FROM Stocks";
            return DatabaseHelperDapper.Execute(sql);
        }
    }

}
