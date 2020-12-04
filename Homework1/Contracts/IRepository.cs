using DogBreeds.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DogBreeds.Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        void Insert(T entity);
        void Update(int id, T entity);
        void Delete(int id);
    }
}
