using DogBreeds.DataBase;
using DogBreeds.Models;
using System.Linq;

namespace DogBreeds.DAL
{
    public static class DbInitializer
    {
        public static void SeedData(DogBreedContext context)
        {
            if (!context.DogBreeds.Any())
            {
                context.DogBreeds.AddRange(
                new DogBreed
                {
                    Breed = "Sealyham Terrier",
                    Country = "England",
                    AverageAge = 13,
                    AverageHeight = 28,
                    UnitOfHeight = "sm",
                    AverageWeight = 9,
                    UnitOfWeight = "kg",
                    AveragePrice = 1000,
                    UnitOfPrice = "$",
                    HairLenght = "Long",
                    Picture = "https://petsi.net/images/dogbreed/small/sealyham-terrier.jpg"
                },
                new DogBreed
                {
                    Breed = "Dachshund",
                    Country = "Germany",
                    AverageAge = 14,
                    AverageHeight = 25,
                    UnitOfHeight = "sm",
                    AverageWeight = 8,
                    UnitOfWeight = "kg",
                    AveragePrice = 500,
                    UnitOfPrice = "$",
                    HairLenght = "Short",
                    Picture = "https://petsi.net/images/dogbreed/small/11.jpg"
                },
                new DogBreed
                {
                    Breed = "Saint Bernard",
                    Country = "Switzerland",
                    AverageAge = 8,
                    AverageHeight = 80,
                    UnitOfHeight = "sm",
                    AverageWeight = 100,
                    UnitOfWeight = "kg",
                    AveragePrice = 1200,
                    UnitOfPrice = "$",
                    HairLenght = "Long",
                    Picture = "https://petsi.net/images/dogbreed/small/104.jpg"
                },
                new DogBreed
                {
                    Breed = "Rottweiler",
                    Country = "Germany",
                    AverageAge = 10,
                    AverageHeight = 63,
                    UnitOfHeight = "sm",
                    AverageWeight = 52,
                    UnitOfWeight = "kg",
                    AveragePrice = 1500,
                    UnitOfPrice = "$",
                    HairLenght = "Short",
                    Picture = "https://petsi.net/images/dogbreed/small/9.jpg"
                },
                new DogBreed
                {
                    Breed = "Riesenschnauzer",
                    Country = "Germany",
                    AverageAge = 13,
                    AverageHeight = 66,
                    UnitOfHeight = "sm",
                    AverageWeight = 30,
                    UnitOfWeight = "kg",
                    AveragePrice = 720,
                    UnitOfPrice = "$",
                    HairLenght = "Medium",
                    Picture = "https://petsi.net/images/dogbreed/small/5.jpg"
                },
                new DogBreed
                {
                    Breed = "Poodle",
                    Country = "France",
                    AverageAge = 14,
                    AverageHeight = 40,
                    UnitOfHeight = "sm",
                    AverageWeight = 20,
                    UnitOfWeight = "kg",
                    AveragePrice = 1200,
                    UnitOfPrice = "$",
                    HairLenght = "Medium",
                    Picture = "https://petsi.net/images/dogbreed/small/poodle.jpg"
                },
                new DogBreed
                {
                    Breed = "Pekingese",
                    Country = "China",
                    AverageAge = 14,
                    AverageHeight = 20,
                    UnitOfHeight = "sm",
                    AverageWeight = 5,
                    UnitOfWeight = "kg",
                    AveragePrice = 700,
                    UnitOfPrice = "$",
                    HairLenght = "Long",
                    Picture = "https://petsi.net/images/dogbreed/small/94.jpg"
                },
                new DogBreed
                {
                    Breed = "Pug",
                    Country = "China",
                    AverageAge = 14,
                    AverageHeight = 27,
                    UnitOfHeight = "sm",
                    AverageWeight = 7,
                    UnitOfWeight = "kg",
                    AveragePrice = 1700,
                    UnitOfPrice = "$",
                    HairLenght = "Short",
                    Picture = "https://petsi.net/images/dogbreed/small/12.jpg"
                },
                new DogBreed
                {
                    Breed = "Collie",
                    Country = "Scotland",
                    AverageAge = 12,
                    AverageHeight = 55,
                    UnitOfHeight = "sm",
                    AverageWeight = 28,
                    UnitOfWeight = "kg",
                    AveragePrice = 550,
                    UnitOfPrice = "$",
                    HairLenght = "Long",
                    Picture = "https://petsi.net/images/dogbreed/small/kolli.jpg"
                },
                new DogBreed
                {
                    Breed = "Doberman",
                    Country = "Germany",
                    AverageAge = 12,
                    AverageHeight = 68,
                    UnitOfHeight = "sm",
                    AverageWeight = 40,
                    UnitOfWeight = "kg",
                    AveragePrice = 1000,
                    UnitOfPrice = "$",
                    HairLenght = "Short",
                    Picture = "https://petsi.net/images/dogbreed/small/56.jpg"
                },
                 new DogBreed
                 {
                     Breed = "Corgi",
                     Country = "Endland",
                     AverageAge = 13,
                     AverageHeight = 27,
                     UnitOfHeight = "sm",
                     AverageWeight = 11,
                     UnitOfWeight = "kg",
                     AveragePrice = 1000,
                     UnitOfPrice = "$",
                     HairLenght = "Medium",
                     Picture = "https://petsi.net/images/dogbreed/small/95.jpg"
                 }
            );
            }
            context.SaveChanges();
        }
    }
}
