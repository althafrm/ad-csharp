using CityEvent.Business.Interfaces;
using CityEvent.Data.Models;
using CityEvent.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityEvent.Business.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;
        public EventService()
        {
            _eventRepository = new EventRepository();
        }
        public void AddEvent(EventModel eventModel)
        {
            _eventRepository.AddEvent(eventModel);
        }
        public List<EventModel> GetAllEvents()
        {
            var events = _eventRepository.GetAllEvents();
            return events;
        }
    }
}
