using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace LrigGlobal.Models
{
    public class Event : LrigBaseModel
    {
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("chapter")]
        public string Chapter { get; set; }
        [BsonElement("eventStart")]
        public DateTime EventStart { get; set; }
        [BsonElement("eventEnd")]
        public DateTime EventEnd { get; set; }
        [BsonElement("additionalInfo")]
        public string AdditionalInfo { get; set; }
        [BsonElement("eventbriteUrl")]
        public string EventbriteUrl { get; set; }
    }   
}