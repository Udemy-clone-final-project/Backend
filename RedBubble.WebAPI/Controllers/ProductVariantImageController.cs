using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.DTOs.Products.ProductVariant.ProductVariantImage;
using RedBubble.Application.Interfaces;

namespace RedBubble.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductVariantImageController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ProductVariantImageController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpGet("product/{productVariantId}")]
        public async Task<IActionResult> GetImagesByProductVariantIdAsync(int productVariantId)
        {
            var images = await _serviceManager.ProductVariantImageService
                .GetImagesByProductVariantIdAsync(productVariantId);
            return Ok(images);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetImageByIdAsync(int id)
        {
            var image = await _serviceManager.ProductVariantImageService.GetImageByIdAsync(id);
            if (image == null)
                return NotFound();
            return Ok(image);
        }
        [HttpPost]
        public async Task<IActionResult> CreateImageAsync(CreateProductVariantImageDto dto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                var image = await _serviceManager.ProductVariantImageService.CreateImageAsync(dto);
                return StatusCode(201, image);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateImageAsync(int id, UpdateProductVariantImageDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var image = await _serviceManager.ProductVariantImageService.UpdateImageAsync(id, dto);
            if (image == null)
                return NotFound();
            else
                return Ok(image);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteImageAsync(int id)
        {
            var deleted = await _serviceManager.ProductVariantImageService.DeleteImageAsync(id);
            if (!deleted)
                return NotFound();
            return NoContent();


        }
        [HttpGet("variant/{productVariantId}/primary")]
        public async Task<ActionResult> GetPrimaryImageAsync(int productVariantId)
        {
            var primaryImage = await _serviceManager.ProductVariantImageService
                   .GetPrimaryImageAsync(productVariantId);

            if (primaryImage == null)
                return NotFound();

            return Ok(primaryImage);
        }
        [HttpPut("product/{productVariantId}/primary/{imageId}")]
        public async Task<IActionResult> SetPrimaryImage(int productVariantId, int imageId)
        {
            
                var success = await _serviceManager.ProductVariantImageService
                    .SetPrimaryImageAsync(productVariantId, imageId);

                if (!success)
                    return NotFound(new { Message = $"Image {imageId} not found or doesn't belong to product variant {productVariantId}" });

                return Ok(new { Message = "Primary image updated successfully" });
            
          
        }
    }
}
