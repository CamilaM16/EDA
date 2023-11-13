using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using service.Models;

namespace service.Services
{
    public abstract class Service<T> : IService<T> 
    {
        protected readonly IMongoCollection<T> _collection;

        public Service(IOptions<EcommersDataBaseSettings> todoSettings, string collectionName)
        {
            var settings = todoSettings.Value;
            var mongoClient = new MongoClient(settings.ConnectionString);
            var mongoDataBase = mongoClient.GetDatabase(settings.DatabaseName);
            _collection = mongoDataBase.GetCollection<T>(collectionName);
        }

        public abstract Task<List<T>> GetAllAsync();
        public abstract Task<T> GetAsync(string id);
        public abstract Task CreateAsync(T newElement);
        public abstract Task UpdateAsync(string id, T updatedElement);
        public abstract Task RemoveAsync(string id);
        
        //public async abstract Task UpdateElementItem();
    }
}