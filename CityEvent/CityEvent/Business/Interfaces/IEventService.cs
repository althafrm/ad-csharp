using CityEvent.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityEvent.Business.Interfaces
{
    public interface IEventService
    {
        List<EventModel> GetAllEvents();
        void AddEvent(EventModel eventModel);
    }
}
