using Ecommerce.Application.Contracts.Interface;
using Ecommerce.Application.DTOs;
using Ecommerce.Application.Repository;
using Ecommerce.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Ecommerce.Application.DTOs.DTOBrand;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _BrandServicecs;

        public BrandController(IBrandService BrandServicecs)
        {
            _BrandServicecs = BrandServicecs;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var Product = await _BrandServicecs.GetAllBrand();
            return Ok(Product);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrandById(int id)
        {
            var Product = await _BrandServicecs.GetBrandById(id);
            if (Product == null)
                return NotFound();

            return Ok(Product);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(DTOBrand Brand)
        {
            await _BrandServicecs.CreateBrand(Brand);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBrand(int id, DTOUpdateBrand Brand)
        {
            if (id != Brand.Id)
                return BadRequest();

            await _BrandServicecs.UpdateBrand(Brand);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            await _BrandServicecs.DeleteBrand(id);
            return NoContent();
        }


    }
}