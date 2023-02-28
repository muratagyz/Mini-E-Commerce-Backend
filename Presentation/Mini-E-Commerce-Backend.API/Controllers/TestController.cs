using Microsoft.AspNetCore.Mvc;
using Mini_E_Commerce_Backend.Application.Repositories;
using Mini_E_Commerce_Backend.Domain.Entities;

namespace Mini_E_Commerce_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public TestController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task AddRange()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product 1",
                    Price = 100,
                    Stock = 10,
                    CreateDate = DateTime.Now,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product 2",
                    Price = 200,
                    Stock = 20,
                    CreateDate = DateTime.Now,
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product 3",
                    Price = 300,
                    Stock = 30,
                    CreateDate = DateTime.Now,
                }
            });

            await _productWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var result = await _productReadRepository.GetByIdAsync(id);
            return Ok(result);
        }
    }
}
