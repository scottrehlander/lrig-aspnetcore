using LrigGlobal.Models;
using LrigGlobal.Utils;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace LrigGlobal.Repositories
{
    public class EventRepository : IEventRepository
    {
        private IMongoDatabase _database;
        private IMongoClient _client;
        public readonly AppConfigurationSettings _configuration;

        public EventRepository(IOptions<AppConfigurationSettings> configuration)
        {
            _configuration = configuration.Value;
            Connect();
        }

        public void Add(Event ev)
        {
            _database.GetCollection<Event>("events").InsertOne(ev);
        }

        public IEnumerable<Event> AllEvents()
        {
            var evs = _database.GetCollection<Event>("events").Find(Builders<Event>.Filter.Empty);
            return evs.ToList();
        }

        public Event GetById(ObjectId id)
        {
            var query = Builders<Event>.Filter.Eq(x => x.Id, id);
            var coll = _database.GetCollection<Event>("events");
            var ev = coll.Find(query).First();

            return ev;
        }

        public bool Remove(ObjectId id)
        {
            var query = Builders<Event>.Filter.Eq(x => x.Id, id);
            var result = _database.GetCollection<Event>("events").DeleteOne(query);

            return GetById(id) == null;
        }

        public void Update(Event ev)
        {
            var query = Builders<Event>.Filter.Eq(x => x.Id, ev.Id);
            _database.GetCollection<Event>("events").ReplaceOne(query, ev);
        }

        private void Connect()
        {
            _client = new MongoClient(string.Format("mongodb://{0}:{1}", _configuration.MongoDB.Host, _configuration.MongoDB.Port));
            _database = _client.GetDatabase(_configuration.MongoDB.Database);
        }
    }
}
