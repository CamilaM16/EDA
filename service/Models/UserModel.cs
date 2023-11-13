using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace service.Models
{
    public class UserModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("role")]
        public string Role { get; set; }

        [BsonElement("secret")]
        public string Secret { get; set; }
    }
}
