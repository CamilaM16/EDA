using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using service.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace service.Services
{
    public class ProductService : Service<Product>
    {
        public ProductService(IOptions<EcommersDataBaseSettings> todoSettings)
            : base(todoSettings, todoSettings.Value.ProductCollectionName)
        {
        }
        public override async Task<List<Product>> GetAllAsync() =>
                    await _collection.Find(_ => true).ToListAsync();

        public override async Task<Product> GetAsync(string id) =>
            await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public override async Task CreateAsync(Product newElement) =>
            await _collection.InsertOneAsync(newElement);

        public override async Task UpdateAsync(string id, Product updatedElement) =>
            await _collection.ReplaceOneAsync(x => x.Id == id, updatedElement);

        public override async Task RemoveAsync(string id) =>
            await _collection.DeleteOneAsync(x => x.Id == id);
    }
}