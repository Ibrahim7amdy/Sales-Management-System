using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SalesManagementSystem.DAL
{
    public static class DatabaseHelperDapper
    {
        static IDbConnection connection;
        static DatabaseHelperDapper()
        {
            connection = new SqlConnection("Data Source=MAHMOUD-ALSHAHA;Initial Catalog=SSTOREONLINE;Integrated Security=True; Encrypt = false;");
        }

        // SELECT - return list of T
        public static List<T> Query<T>(string sql)
        {
            return connection.Query<T>(sql).ToList();
        }

        // SELECT - return single row
        public static T? QuerySingleOrDefault<T>(string sql)
        {
            return connection.QuerySingleOrDefault<T>(sql);
        }

        // DML (INSERT, UPDATE, DELETE) - return affected rows > 0
        public static bool Execute(string sql)
        {
            int rowsAffected = connection.Execute(sql);
            return rowsAffected > 0;
        }

        // Execute multiple DML commands inside one transaction
        public static bool ExecuteTransaction(List<(string Sql, object? Params)> commands)
        {
            connection.Open();
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    foreach (var cmd in commands)
                    {
                        connection.Execute(cmd.Sql, cmd.Params, transaction);
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
                    connection.Close();
                }
            }
        }
    }

}
