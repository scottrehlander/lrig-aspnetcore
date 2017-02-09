using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace LrigGlobal.Models
{
    public class Chapter : LrigBaseModel
    {
        [BsonElement("name")]
        public string Name { get; set; }
    }
}