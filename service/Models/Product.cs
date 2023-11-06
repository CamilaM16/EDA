using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

public class Buyer
{
    [BsonElement("buyer_id")]
    [BsonRepresentation(BsonType.ObjectId)]
    public ObjectId BuyerId { get; set; }

    [BsonElement("quantity")]
    public int Quantity { get; set; }

    [BsonElement("ratings")]
    public List<Rating> Ratings { get; set; }
}

public class Rating
{
    [BsonElement("user_id")]
    [BsonRepresentation(BsonType.ObjectId)]
    public ObjectId UserId { get; set; }
    
    [BsonElement("score")]
    public int Score { get; set; }
}

public class Product
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public ObjectId Id { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("details")]
    public string Details { get; set; }

    [BsonElement("quantity")]
    public int Quantity { get; set; }

    [BsonElement("price")]
    public double Price { get; set; }

    [BsonElement("vendor")]
    [BsonRepresentation(BsonType.ObjectId)]
    public ObjectId VendorId { get; set; }

    [BsonElement("list_buyers")]
    public List<Buyer> Buyers { get; set; }

    [BsonElement("date_publics")]
    public DateTime DatePublics { get; set; }

    [BsonElement("date_update")]
    public DateTime DateUpdate { get; set; }
}