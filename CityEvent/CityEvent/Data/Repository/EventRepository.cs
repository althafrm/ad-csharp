using CityEvent.Data.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CityEvent.Data.Repository
{
    public class EventRepository : IEventRepository
    {

        string connectionString = "Data Source=LAPTOP-F4TUI078;Initial Catalog=CityEvent;Integrated Security=True;Connect Timeout=30;" +
            "Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        #region AddEvent
        public void AddEvent(EventModel eventRequest)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO Events(Id,Name,DateTime,Venue,Type,Capacity,TicketPrice) VALUES (@id,@name,@datetime,@venue,@type,@capacity,@ticketprice)";

                try
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", Guid.NewGuid());
                        command.Parameters.AddWithValue("@name", eventRequest.Name);
                        command.Parameters.AddWithValue("@datetime", eventRequest.DateTime);
                        command.Parameters.AddWithValue("@venue", eventRequest.Venue);
                        command.Parameters.AddWithValue("@type", eventRequest.Type);
                        command.Parameters.AddWithValue("@capacity", eventRequest.Capacity);
                        command.Parameters.AddWithValue("@ticketprice", eventRequest.TicketPrice);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region GetAllEvents
        //Get All Customer
        public List<EventModel> GetAllEvents()
        {
            var events = new List<EventModel>();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM Events";
                    using (var command = new SqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                events.Add(new EventModel()
                                {
                                    Id = reader.GetGuid(0),
                                    Name = reader.GetString(1),
                                    DateTime = reader.GetDateTime(2),
                                    Venue = reader.GetString(3),
                                    Type = reader.GetString(4),
                                    Capacity = reader.GetInt32(5),
                                    TicketPrice = reader.GetDecimal(6),
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching events: {ex.Message}");
            }

            return events;
        }
        #endregion
    }
}
