using Ecommerce.Application.Contracts.Interface;
using Ecommerce.Application.Contracts.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishlistController : ControllerBase
    {
        private readonly IWishlistService _WishlistService;

        public WishlistController(IWishlistService WishlistService)
        {
            _WishlistService = WishlistService;
        }
      
        [HttpPost("add")]
        public async Task<IActionResult> AddProductToWishlist(int productId, int userId)
        {
            if (productId <= 0 || userId <= 0)
                return BadRequest("Invalid product or user ID");

            await _WishlistService.AddProductToWishlistAsync(productId, userId);
            return Ok("Product added to wishlist successfully");
        }

        
        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetAllByUserId(int userId)
        {
            if (userId <= 0)
                return BadRequest("Invalid user ID");

            var wishlistItems = await _WishlistService.GetAllByUserId(userId);
            if (wishlistItems == null || !wishlistItems.Any())
                return NotFound("No items found in the wishlist");

            return Ok(wishlistItems);
        }

        
        [HttpDelete("remove")]
        public async Task<IActionResult> RemoveProductFromWishlist(int productId, int userId)
        {
            if (productId <= 0 || userId <= 0)
                return BadRequest("Invalid product or user ID");

            await _WishlistService.RemoveProductFromWishlistAsync(productId, userId);
            return Ok("Product removed from wishlist successfully");
        }
    }



}
