using Ecommerce.Application.Contracts.Interface;
using Ecommerce.Application.Contracts.Services;
using Ecommerce.Application.DTOs;
using Ecommerce.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Ecommerce.Application.DTOs.DTOvisa;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisaController : ControllerBase
    {

        private readonly IVisaService _VisaService;

        public VisaController(IVisaService VisaService)
        {
            _VisaService = VisaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVisa()
        {
            var visas = await _VisaService.GetAllVisa();
            return Ok(visas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVisaById(int id)
        {
            var visa = await _VisaService.GetVisaById(id);
            if (visa == null)
                return NotFound();

            return Ok(visa);
        }

        [HttpPost]
        public async Task<IActionResult> CreateVisa(DTOvisa visa)
        {
            await _VisaService.CreateVisa(visa);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVisat(int id, DTOUpdatevisa visa)
        {
            if (id != visa.id)
                return BadRequest();

            await _VisaService.UpdateVisa(visa);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVisa(int id)
        {
            await _VisaService.DeleteVisa(id);
            return NoContent();
        }


    }
}