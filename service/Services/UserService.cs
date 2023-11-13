using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using service.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace service.Services
{
    public class UserService : Service<User>
    {
        public UserService(IOptions<EcommersDataBaseSettings> todoSettings)
            : base(todoSettings, todoSettings.Value.UserCollectionName)
        {
        }

        public override async Task<List<User>> GetAllAsync() =>
            await _collection.Find(_ => true).ToListAsync();

        public override async Task<User> GetAsync(string id) =>
            await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public override async Task CreateAsync(User newElement) =>
            await _collection.InsertOneAsync(newElement);

        public override async Task UpdateAsync(string id, User updatedElement) =>
            await _collection.ReplaceOneAsync(x => x.Id == id, updatedElement);

        public override async Task RemoveAsync(string id) =>
            await _collection.DeleteOneAsync(x => x.Id == id);
    }
}