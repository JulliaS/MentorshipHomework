using DogBreeds.Contracts;
using DogBreeds.DataBase;
using DogBreeds.Models;
using System;
using System.Threading.Tasks;

namespace DogBreeds.DAL
{
    public class UnitOfWork<T> : IUnitOfWork<T>, IDisposable where T : BaseEntity
    {
        private readonly DogBreedContext _context;
        private IRepository<T> _repository;

        public UnitOfWork(DogBreedContext context)
        {
            _context = context;
        }

        public IRepository<T> Repository
        {
            get { return _repository ?? (_repository = new Repository<T>(_context)); }
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }


        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
