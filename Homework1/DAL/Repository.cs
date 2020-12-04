using DogBreeds.Contracts;
using DogBreeds.DataBase;
using DogBreeds.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogBreeds.DAL
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly DogBreedContext context;
        private DbSet<T> entities;
        string nullEntityErrorMessage = "Null entity";
        string dublicateIdErrorMessage = "Entity should be sent without Id because entity with such Id can be already in database";
        string notFoundErrorMessage = "Entity not found";

        public Repository(DogBreedContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await entities.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await entities.SingleOrDefaultAsync(s => s.Id == id);
        }

        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nullEntityErrorMessage);
            if (entity.Id != 0) throw new ArgumentException(dublicateIdErrorMessage);

                entities.Add(entity);
        }

        public void Update(int id, T entity)
        {
            if (entity == null) throw new ArgumentNullException(nullEntityErrorMessage);
            if (!entities.Any(x => x.Id == id))
            {
                throw new ArgumentNullException(notFoundErrorMessage);
            }

            entity.Id = id;

            context.Update(entity);
        }

        public void Delete(int id)
        {
            T entity = entities.SingleOrDefault(s => s.Id == id);
            if (entity == null) throw new ArgumentNullException(notFoundErrorMessage);

            entities.Remove(entity);
        }

    }
}
