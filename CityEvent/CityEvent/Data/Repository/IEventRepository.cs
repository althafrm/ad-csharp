using CityEvent.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityEvent.Data.Repository
{
    public interface IEventRepository
    {
        List<EventModel> GetAllEvents();
        void AddEvent(EventModel eventRequest);
    }
}
