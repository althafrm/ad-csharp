using BookManagement.Data.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Data.Repository
{
    public class CustomerRepository : IcustomerRepository
    {
        string connectionString = "Data Source=LAPTOP-F4TUI078;Initial Catalog=BookManagement;Integrated Security=True;Connect Timeout=30;" +
            "Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        #region GetAllCustomers
        //Get All Customer
        public List<CustomerModel> GetAllCustomers()
        {
            var customers = new List<CustomerModel>();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM Customer";
                    using (var command = new SqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                customers.Add(new CustomerModel()
                                {
                                    Id = reader.GetGuid(0),
                                    Name = reader.GetString(1),
                                    Nic = reader.GetString(2),
                                    Contact = reader.GetString(3),
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching customers: {ex.Message}");
            }
            return customers;
        }
        #endregion

        #region AddCustomer
        public void AddCustomer(CustomerModel customer)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO Customer(Id,Name,Nic,Contact) VALUES(@id, @name,@nic, @contact)";
                try
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", Guid.NewGuid());
                        command.Parameters.AddWithValue("@name", customer.Name);
                        command.Parameters.AddWithValue("@nic", customer.Nic);
                        command.Parameters.AddWithValue("@contact", customer.Contact);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding customer: {ex.Message}");
                }

            }
        }

        #endregion
    }
}
