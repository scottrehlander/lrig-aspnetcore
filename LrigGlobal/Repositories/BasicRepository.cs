using LrigGlobal.Models;
using LrigGlobal.Utils;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace LrigGlobal.Repositories
{
    public class BasicRepository<T> : IRepository<T> where T : LrigBaseModel
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoClient _client;
        public readonly AppConfigurationSettings _configuration;
        protected readonly string _baseCollectionName;

        public BasicRepository(IOptions<AppConfigurationSettings> configuration, string baseCollectionName) 
        {
            _baseCollectionName = baseCollectionName;
            _configuration = configuration.Value;

            _client = new MongoClient(string.Format("mongodb://{0}:{1}", _configuration.MongoDB.Host, _configuration.MongoDB.Port));
            _database = _client.GetDatabase(_configuration.MongoDB.Database);
        }

        public void Add(T item)
        {
            _database.GetCollection<T>(_baseCollectionName).InsertOne(item);
        }

        public IEnumerable<T> GetAll()
        {
            var items = _database.GetCollection<T>(_baseCollectionName).Find(Builders<T>.Filter.Empty);
            return items.ToList();
        }

        public T GetById(ObjectId id)
        {
            var query = new BsonDocument(new Dictionary<string, object> { { "_id", id } });
            var coll = _database.GetCollection<T>(_baseCollectionName);
            var item = coll.Find(query).First();

            return item;
        }

        public bool Remove(ObjectId id)
        {
            var query = Builders<T>.Filter.Eq(x => x.Id, id);
            var result = _database.GetCollection<T>(_baseCollectionName).DeleteOne(query);

            return GetById(id) == null;
        }

        public void Update(T item) 
        {
            var query = new BsonDocument(new Dictionary<string, object> { { "_id", item.Id } });
            _database.GetCollection<T>(_baseCollectionName).ReplaceOne(query, item);
        }
        
    }
}
