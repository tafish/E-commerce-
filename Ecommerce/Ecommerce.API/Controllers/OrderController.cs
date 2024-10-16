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
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }


        [HttpPost]
        public async Task<IActionResult> CreateOrder(DTOOrder order)
        {
            await _orderService.CreateOrder(order);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteorder(int id)
        {
            await _orderService.DeleteOrder(id);
            return NoContent();
        }
       
        [HttpPatch("{id}/status")]
        public async Task<IActionResult> ChangeOrderStatus(int id, [FromBody] string newStatus)
        {
            try
            {      
                await _orderService.ChangeOrderStatus(id, newStatus);
 
                return Ok(new { message = $"Order {id} status changed to {newStatus}" });
            }
            catch (ArgumentException ex)
            {    
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {  
                return StatusCode(500, new { message = "The order will be reviewed with the delivery company.", details = ex.Message });
            }

        }
    }
}
