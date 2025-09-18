using SalesManagementSystem.DAL.Models;
using SalesManagementSystem.DAL;
using System.Data;

namespace SalesManagementSystem.BLL.Services
{
    public static class CategoryService
    {
        //GetAllCategorys
        public static List<Category> GetAllCategorys()
        {
            var dataTable = DatabaseHelper.ExecuteSelect("SELECT * FROM Categorys");
            List<Category> Categorys = new List<Category>();
            foreach (DataRow row in dataTable.Rows)
            {
                Categorys.Add(new Category
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Name = row["Name"].ToString(),
                });
            }
            return Categorys;
        }

        public static List<Category> GetAllCategorysByPattern(string Pattern)
        {
            var dataTable = DatabaseHelper.ExecuteSelect($"SELECT * FROM Categorys where Name Like N'%{Pattern}%' ");
            List<Category> Categorys = new List<Category>();
            foreach (DataRow row in dataTable.Rows)
            {
                Categorys.Add(new Category
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Name = row["Name"].ToString(),
                });
            }
            return Categorys;
        }

        //GetCategoryByID
        public static Category? GetCategoryByID(int id)
        {
            var dataTable = DatabaseHelper.ExecuteSelect($"SELECT * FROM Categorys WHERE ID = {id}");

            if (dataTable.Rows.Count == 0)
                return null;

            var row = dataTable.Rows[0];
            return new Category
            {
                ID = Convert.ToInt32(row["ID"]),
                Name = row["Name"].ToString(),
            };
        }

        //AddCategory
        public static bool AddCategory(Category Category)
        {
            bool Result = DatabaseHelper.ExecuteDML($"INSERT INTO Categorys (Name) VALUES (N'{Category.Name}')");
            return Result;
        }

        //UpdateCategory
        public static bool UpdateCategory(Category Category)
        {
            bool Result = DatabaseHelper.ExecuteDML($"UPDATE Categorys SET Name = N'{Category.Name}' WHERE ID = {Category.ID}");
            return Result;
        }

        //DeleteCategory
        public static bool DeleteCategory(int id)
        {
            bool Result = DatabaseHelper.ExecuteDML($"DELETE FROM Categorys WHERE ID = {id}");
            return Result;
        }

        public static bool DeleteAllCategory()
        {
            bool Result = DatabaseHelper.ExecuteDML($"DELETE FROM Categorys");
            return Result;
        }
    }
}
