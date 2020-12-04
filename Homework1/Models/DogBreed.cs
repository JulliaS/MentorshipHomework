namespace DogBreeds.Models
{
    public class DogBreed : BaseEntity
    {
        public string Breed { get; set; }
        public string Country { get; set; }
        public double? AverageAge { get; set; }
        public double? AverageWeight { get; set; }
        public string UnitOfWeight { get; set; }
        public double? AverageHeight { get; set; }
        public string UnitOfHeight { get; set; }
        public string HairLenght { get; set; }
        public decimal? AveragePrice { get; set; }
        public string UnitOfPrice { get; set; }
        public string Picture { get; set; }
    }
}
