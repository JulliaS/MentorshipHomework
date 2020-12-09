using System.Collections.Generic;
using System.Threading.Tasks;
using DogBreeds.Contracts;
using DogBreeds.Models;
using Microsoft.AspNetCore.Mvc;

namespace DogBreeds.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogBreedController : ControllerBase
    {
        private readonly IUnitOfWork<DogBreed> _unitOfWork;
        public DogBreedController(IUnitOfWork<DogBreed> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IEnumerable<DogBreed>> GetAllDogBreeds() => await _unitOfWork.Repository.GetAll();

        [HttpGet("{id}")]
        public async Task<DogBreed> GetDogBreedById(int id) => await _unitOfWork.Repository.GetById(id);

        [HttpPost]
        public async Task AddDogBreed([FromBody] DogBreed dogBreed)
        {
            _unitOfWork.Repository.Insert(dogBreed);
            await _unitOfWork.Save();
        }

        [HttpPut("{id}")]
        public async Task UpdateDogBreed(int id, [FromBody] DogBreed dogBreed)
        {
            _unitOfWork.Repository.Update(id, dogBreed);
            await _unitOfWork.Save();
        }

        [HttpDelete("{id}")]
        public async Task DeleteDogBreed(int id) 
        { 
            _unitOfWork.Repository.Delete(id);
            await _unitOfWork.Save();
        }
    }
}
