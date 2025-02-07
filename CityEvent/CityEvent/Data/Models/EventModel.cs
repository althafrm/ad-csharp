using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityEvent.Data.Models
{
    public class EventModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public string Venue { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public decimal TicketPrice { get; set; }
    }
}
