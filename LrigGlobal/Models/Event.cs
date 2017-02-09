using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace LrigGlobal.Models
{
    public class Event
    {
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("date")]
        public DateTime date { get; set; }
        [BsonElement("eventbriteUrl")]
        public string EventbriteUrl { get; set; }
    }
}