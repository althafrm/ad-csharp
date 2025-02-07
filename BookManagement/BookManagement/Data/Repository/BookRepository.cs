using BookManagement.Data.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Data.Repository
{
    public class BookRepository
    {
        string connectionString = "Server=localhost;Database=BookManagement;Integrated Security=True;TrustServerCertificate=True;";

        //GetAllbooks
        public List<Book> GetAllBoks()
        {
            var books = new List<Book>();
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM Book";

                using(var command = new SqlCommand(query, connection))
                {
                    using(var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book
                            {
                                Id = reader.GetGuid(0),
                                Name = reader.GetString(1),
                                Isbn = reader.GetString(2),
                                Author = reader.GetString(3),
                            });
                        }
                    }
                }
            }
            return books;
        }
    }
}
