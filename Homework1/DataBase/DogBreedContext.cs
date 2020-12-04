using DogBreeds.Models;
using Microsoft.EntityFrameworkCore;

namespace DogBreeds.DataBase
{
    public class DogBreedContext : DbContext
    {
        public DbSet<DogBreed> DogBreeds { get; set; }
        public DogBreedContext(DbContextOptions<DogBreedContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
