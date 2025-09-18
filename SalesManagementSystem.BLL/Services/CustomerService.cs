using SalesManagementSystem.DAL.Models;
using SalesManagementSystem.DAL;
using System.Data;
using SalesManagementSystem.BLL.Dtos;

namespace SalesManagementSystem.BLL.Services
{
    public static class CustomerService
    {
        //GetAllCustomers
        public static List<Customer> GetAllCustomers()
        {
            var dataTable = DatabaseHelper.ExecuteSelect("SELECT * FROM Customers");
            List<Customer> Customers = new List<Customer>();
            foreach (DataRow row in dataTable.Rows)
            {
                Customers.Add(new Customer
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Name = row["Name"].ToString(),
                    PhoneNumber = row["PHONENUMBER"].ToString(),
                    Address = row["ADDRESS"].ToString(),
                    BirthDate = Convert.ToDateTime(row["BIRTHDATE"]),
                });
            }
            return Customers;
        }
        public static List<CustomerReadBasicDto> GetAllBasicCustomers()
        {
            var dataTable = DatabaseHelper.ExecuteSelect("SELECT ID , NAME FROM Customers");
            List<CustomerReadBasicDto> customers = new List<CustomerReadBasicDto>();
            foreach (DataRow row in dataTable.Rows)
            {
                customers.Add(new CustomerReadBasicDto
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Name = row["Name"].ToString(),
                });
            }
            return customers;
        }
        public static List<Customer> GetAllCustomersByPattern(string Pattern)
        {
            var dataTable = DatabaseHelper.ExecuteSelect($"SELECT * FROM Customers where Name Like N'%{Pattern}%' or PHONENUMBER Like N'%{Pattern}%' or ADDRESS Like N'%{Pattern}%' ");
            List<Customer> Customers = new List<Customer>();
            foreach (DataRow row in dataTable.Rows)
            {
                Customers.Add(new Customer
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Name = row["Name"].ToString(),
                    PhoneNumber = row["PHONENUMBER"].ToString(),
                    Address = row["ADDRESS"].ToString(),
                    BirthDate = Convert.ToDateTime(row["BIRTHDATE"]),
                });
            }
            return Customers;
        }

        //GetCustomerByID
        public static Customer? GetCustomerByID(int id)
        {
            var dataTable = DatabaseHelper.ExecuteSelect($"SELECT * FROM Customers WHERE ID = {id}");

            if (dataTable.Rows.Count == 0)
                return null;

            var row = dataTable.Rows[0];
            return new Customer
            {
                ID = Convert.ToInt32(row["ID"]),
                Name = row["Name"].ToString(),
                PhoneNumber = row["PHONENUMBER"].ToString(),
                Address = row["ADDRESS"].ToString(),
                BirthDate = Convert.ToDateTime(row["BIRTHDATE"]),
            };
        }

        //AddCustomer
        public static bool AddCustomer(Customer Customer)
        {
            bool Result = DatabaseHelper.ExecuteDML($"INSERT INTO Customers (Name,PhoneNumber,ADDRESS,BIRTHDATE) VALUES (N'{Customer.Name}',N'{Customer.PhoneNumber}',N'{Customer.Address}','{Customer.BirthDate}')");
            return Result;
        }

        //UpdateCustomer
        public static bool UpdateCustomer(Customer Customer)
        {
            bool Result = DatabaseHelper.ExecuteDML($"UPDATE Customers SET Name = N'{Customer.Name}',PhoneNumber = N'{Customer.PhoneNumber}',Address = N'{Customer.Address}',BirthDate = N'{Customer.BirthDate}' WHERE ID = {Customer.ID}");
            return Result;
        }

        //DeleteCustomer
        public static bool DeleteCustomer(int id)
        {
            bool Result = DatabaseHelper.ExecuteDML($"DELETE FROM Customers WHERE ID = {id}");
            return Result;
        }

        public static bool DeleteAllCustomer()
        {
            bool Result = DatabaseHelper.ExecuteDML($"DELETE FROM Customers");
            return Result;
        }
    }
}
