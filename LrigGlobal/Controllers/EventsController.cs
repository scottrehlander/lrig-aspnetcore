using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LrigGlobal.Models;
using LrigGlobal.Repositories;

namespace LrigGlobal.Controllers
{
    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        private readonly IEventRepository _eventRepository;

        public EventsController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        [HttpGet("[action]")]
        public IEnumerable<Event> GetEvents()
        {
            return _eventRepository.AllEvents();
        }
      
    }
}
