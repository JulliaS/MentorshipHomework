using DogBreeds.Models;
using System.Threading.Tasks;

namespace DogBreeds.Contracts
{
    public interface IUnitOfWork<T> where T : BaseEntity
    {
        IRepository<T> Repository { get; }
        Task Save();
    }
}
