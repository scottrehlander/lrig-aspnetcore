using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LrigGlobal.Models;

namespace LrigGlobal.Repositories
{
    public interface IEventRepository
    {
        IEnumerable<Event> AllEvents();

        Event GetById(ObjectId id);

        void Add(Event ev);

        void Update(Event speaker);

        bool Remove(ObjectId id);
    }
}
