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
        [BsonElement("chair")]
        public string Chair { get; set; }
        [BsonElement("shortDescription")]
        public string ShortDescription { get; set; }
        [BsonElement("homePageBody")]
        public string HomePageBody { get; set; }
    }
}