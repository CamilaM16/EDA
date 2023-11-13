using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using service.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace service.Services
{
    public class CategoryService : Service<CategoryModel>
    {
        public CategoryService(IOptions<EcommersDataBaseSettings> todoSettings)
            : base(todoSettings, todoSettings.Value.CategoriesCollectionName)
        {
        }

        public override async Task<List<CategoryModel>> GetAllAsync() =>
            await _collection.Find(_ => true).ToListAsync();

        public override async Task<CategoryModel> GetAsync(string id) =>
            await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public override async Task CreateAsync(CategoryModel newElement) =>
            await _collection.InsertOneAsync(newElement);

        public override async Task UpdateAsync(string id, CategoryModel updatedElement) =>
            await _collection.ReplaceOneAsync(x => x.Id == id, updatedElement);

        public override async Task RemoveAsync(string id) =>
            await _collection.DeleteOneAsync(x => x.Id == id);
    }
}