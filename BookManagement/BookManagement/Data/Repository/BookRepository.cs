using BookManagement.Data.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BookManagement.Data.Repository
{
    public class BookRepository
    {
        string connectionString = "Data Source=LAPTOP-F4TUI078;Initial Catalog=BookManagement;Integrated Security=True;Connect Timeout=30;" +
            "Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        //GetAllbooks
        public List<Book> GetAllBoks()
        {
            var books = new List<Book>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM Book";

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
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

        public void AddBook(string name, string isbn, string author)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO Book(Id, Name,Isbn,Author) VALUES (@id, @name,@isbn, @author)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", Guid.NewGuid());
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@isbn", isbn);
                    command.Parameters.AddWithValue("@author", author);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
