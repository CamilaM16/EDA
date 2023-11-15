using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace service.Models;

public class Invoice
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("data")]
    public DateTime Data { get; set; }

    [BsonElement("buyer_id")]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? BuyerId { get; set; }

    [BsonElement("product_list")]
    public List<ProductItem>? ProductList { get; set; }

    [BsonElement("total")]
    public double Total { get; set; }
}

public class ProductItem
{
    [BsonElement("product_id")]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? ProductId { get; set; }

    [BsonElement("quantity")]
    public long Quantity { get; set; }
}
