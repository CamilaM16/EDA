using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using service.Models;

namespace service.Services
{
    public interface IService<T> 
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(string id);
        Task CreateAsync(T newElement);
        Task UpdateAsync(string id, T updatedElement);
        Task RemoveAsync(string id);
        //Task UpdateElementItem();
    }
}