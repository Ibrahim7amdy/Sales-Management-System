using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DAL
{
    public static class DatabaseHelper
    {
        static SqlConnection sqlConnection;
        static DatabaseHelper()
        {
            sqlConnection = new SqlConnection("Data Source=MAHMOUD-ALSHAHA;Initial Catalog=SSTOREONLINE;Integrated Security=True; Encrypt = false;");
        }
        public static DataTable ExecuteSelect(string query)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }
        public static bool ExecuteDML(string command)
        {
            using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
            {
                sqlConnection.Open();
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                return rowsAffected > 0;
            }
        }
        // Execute multiple DML commands inside one transaction
        public static bool ExecuteTransaction(List<string> commands)
        {
            sqlConnection.Open();
            using (SqlTransaction transaction = sqlConnection.BeginTransaction())
            {
                try
                {
                    foreach (var command in commands)
                    {
                        using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection, transaction))
                        {
                            sqlCommand.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
