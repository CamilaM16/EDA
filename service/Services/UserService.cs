using service.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace service.Services
{
    public class UserService : Service<UserModel>
    {
        public UserService(IOptions<EcommersDataBaseSettings> todoSettings)
            : base(todoSettings, todoSettings.Value.UserCollectionName)
        {
        }

        public override async Task<List<UserModel>> GetAllAsync() {
            var result = await _collection.Find(_ => true).ToListAsync();
            Console.Write(result);
            return result;
        }

        public override async Task<UserModel> GetAsync(string id) =>
            await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public override async Task CreateAsync(UserModel newElement) =>
            await _collection.InsertOneAsync(newElement);

        public override async Task UpdateAsync(string id, UserModel updatedElement) =>
            await _collection.ReplaceOneAsync(x => x.Id == id, updatedElement);

        public override async Task RemoveAsync(string id) =>
            await _collection.DeleteOneAsync(x => x.Id == id);
    }
}