﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace LrigGlobal.Models
{
    public class Event : LrigBaseModel
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("date")]
        public DateTime date { get; set; }

        [BsonElement("eventbriteUrl")]
        public string EventbriteUrl { get; set; }
    }
}