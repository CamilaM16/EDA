using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using service.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace service.Services
{
    public class ProductService
    {
        private readonly IMongoCollection<Product> _collection;

        public ProductService(IOptions<EcommersDataBaseSettings> todoSettings)
        {
            var settings = todoSettings.Value;
            var mongoClient = new MongoClient(settings.ConnectionString);
            var mongoDataBase = mongoClient.GetDatabase(settings.DatabaseName);
            _collection = mongoDataBase.GetCollection<Product>(settings.ProductCollectionName);
        }

        public async Task<List<Product>> GetAllAsync() =>
            await _taskCollection.Find(_ => true).ToListAsync();
    }
}