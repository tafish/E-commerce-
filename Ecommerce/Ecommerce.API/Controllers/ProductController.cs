using Ecommerce.Application.Contracts.Interface;
using Ecommerce.Application.Contracts.Services;
using Ecommerce.Application.DTOs;
using Ecommerce.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServicecs _ProductServicecs;

        public ProductController(IProductServicecs ProductServicecs)
        {
            _ProductServicecs = ProductServicecs;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var Product = await _ProductServicecs.GetAllProduct();
            return Ok(Product);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var Product = await _ProductServicecs.GetProductById(id);
            if (Product == null)
                return NotFound();

            return Ok(Product);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(DTOProduct Product)
        {
            await _ProductServicecs.CreateProduct(Product);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, DTOProduct Product)
        {
            if (id != Product.Id)
                return BadRequest();

            await _ProductServicecs.UpdateProduct(Product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _ProductServicecs.DeleteProduct(id);
            return NoContent();
        }


    }
}

    

