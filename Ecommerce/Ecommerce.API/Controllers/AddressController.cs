using Ecommerce.Application.Contracts.Interface;
using Ecommerce.Application.Contracts.Services;
using Ecommerce.Application.DTOs;
using Ecommerce.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Ecommerce.Application.DTOs.DTOAddress;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _AddressService;

        public AddressController(IAddressService AddressService)
        {
            _AddressService = AddressService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAddress(DTOAddress Address)
        {
            await _AddressService.CreateAddress(Address);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAddress()
        {
            var categories = await _AddressService.GetAllAddress();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddressById(int id)
        {
            var category = await _AddressService.GetAddressById(id);
            if (category == null)
                return NotFound();

            return Ok(category);
        }

       

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAddress(int id, DTOUpdateAddress Address)
        {
            if (id != Address.Id)
                return BadRequest();

            await _AddressService.UpdateAddress(Address);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            await _AddressService.DeleteAddress(id);
            return NoContent();
        }


    }
}