using SalesManagementSystem.DAL.Models;
using SalesManagementSystem.DAL;
using System.Data;

namespace SalesManagementSystem.BLL.Services
{
    public static class StockService
    {
        //GetAllStocks
        public static List<Stock> GetAllStocks()
        {
            var dataTable = DatabaseHelper.ExecuteSelect("SELECT * FROM Stocks");
            List<Stock> Stocks = new List<Stock>();
            foreach (DataRow row in dataTable.Rows)
            {
                Stocks.Add(new Stock
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Name = row["Name"].ToString(),
                    TotalMoney =Convert.ToDouble(row["TotalMoney"])
                });
            }
            return Stocks;
        }

        public static List<Stock> GetAllStocksByPattern(string Pattern)
        {
            var dataTable = DatabaseHelper.ExecuteSelect($"SELECT * FROM Stocks where Name Like N'%{Pattern}%' ");
            List<Stock> Stocks = new List<Stock>();
            foreach (DataRow row in dataTable.Rows)
            {
                Stocks.Add(new Stock
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Name = row["Name"].ToString(),
                    TotalMoney = Convert.ToDouble(row["TotalMoney"])
                });
            }
            return Stocks;
        }

        //GetStockByID
        public static Stock? GetStockByID(int id)
        {
            var dataTable = DatabaseHelper.ExecuteSelect($"SELECT * FROM Stocks WHERE ID = {id}");

            if (dataTable.Rows.Count == 0)
                return null;

            var row = dataTable.Rows[0];
            return new Stock
            {
                ID = Convert.ToInt32(row["ID"]),
                Name = row["Name"].ToString(),
                TotalMoney = Convert.ToDouble(row["TotalMoney"])
            };
        }

        //AddStock
        public static bool AddStock(Stock Stock)
        {
            bool Result = DatabaseHelper.ExecuteDML($"INSERT INTO Stocks (Name,TotalMoney) VALUES (N'{Stock.Name}',{Stock.TotalMoney})");
            return Result;
        }

        //UpdateStock
        public static bool UpdateStock(Stock Stock)
        {
            bool Result = DatabaseHelper.ExecuteDML($"UPDATE Stocks SET Name = N'{Stock.Name}',TotalMoney = {Stock.TotalMoney} WHERE ID = {Stock.ID}");
            return Result;
        }
        //UpdateStock
        public static bool UpdateStockMoneyMinus(Stock Stock)
        {
            bool Result = DatabaseHelper.ExecuteDML($"UPDATE Stocks SET TotalMoney = TotalMoney - {Stock.TotalMoney} WHERE ID = {Stock.ID}");
            return Result;
        }
        public static bool UpdateStockMoneyPlus(Stock Stock)
        {
            bool Result = DatabaseHelper.ExecuteDML($"UPDATE Stocks SET TotalMoney = TotalMoney + {Stock.TotalMoney} WHERE ID = {Stock.ID}");
            return Result;
        }
        public static string UpdateStockMoneyPlusGetCommand(Stock Stock)
        {
            string command = $"UPDATE Stocks SET TotalMoney = TotalMoney + {Stock.TotalMoney} WHERE ID = {Stock.ID}";
            return command;
        }


        //DeleteStock
        public static bool DeleteStock(int id)
        {
            bool Result = DatabaseHelper.ExecuteDML($"DELETE FROM Stocks WHERE ID = {id}");
            return Result;
        }

        public static bool DeleteAllStock()
        {
            bool Result = DatabaseHelper.ExecuteDML($"DELETE FROM Stocks");
            return Result;
        }
    }
}
