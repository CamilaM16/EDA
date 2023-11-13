using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace service.Models
{
    public class CategoryModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("id")]
        public int IdCategory { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }
    }
}
