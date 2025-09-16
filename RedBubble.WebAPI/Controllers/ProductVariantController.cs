using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.Interfaces;
using RedBubble.Application.DTOs.Products;
using System.Threading.Tasks;
using RedBubble.Application.DTOs.Products.ProductVariant;

namespace RedBubble.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductVariantController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ProductVariantController( IServiceManager serviceManager)
        {
            _serviceManager = serviceManager; 
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductVariants(string? searchItem, string? sortColomn, string? sortOrder
            , int? Category, int page = 1, int pageSize = 10)
        {
            if (page <= 0) page = 1;
            if (pageSize <= 0) pageSize = 10;

            var products = await _serviceManager.productVariantService.GetAllProductVariantsAsync( searchItem,sortColomn, sortOrder,  Category,  page,  pageSize);
            return Ok(products);     
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetProductVariant(int id)
        {

           
                var product = await _serviceManager.productVariantService.GetByIdAsync(id);
            if (product == null)
                return NotFound();

            return Ok(product);
            
           
        }
        //[HttpPost]
        //public async Task<IActionResult> CreateProductVariantAsync(CreateProductVariantDto dto)
        //{
        //    try
        //    {
        //        if (!ModelState.IsValid)
        //            return BadRequest(ModelState);
        //        var product = await _serviceManager.productVariantService.CreateAsync(dto);
        //        return StatusCode(201, product);
        //        //OR return CreatedAtAction(nameof(GetProductVariant), new { id = product.Id }, product);

        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new { Message = ex.Message });
        //    }
        //}
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateProductVariantAsync(int id,[FromBody]UpdateProductVariantDto dto)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    var product = await _serviceManager.productVariantService.UpdateAsync(dto);
        //    if (product == null)
        //        return NotFound();

        //    return Ok(product);
            
           
        //}
        //[HttpDelete("{id}")]
        //public async Task<ActionResult> DeleteProductVariant(int id)
        //{ 
        //        var deleted = await _serviceManager.productVariantService.DeleteAsync(id);
        //    if (!deleted)
        //        return NotFound();
        //    return NoContent();
            
           
        //}
        //[HttpPut("{id}/stock")]
        //public async Task<IActionResult> UpdateStock(int id, [FromQuery] int quantity)
        //{
        //    var updated = await _serviceManager.productVariantService.UpdateStockQuantityAsync(id, quantity);
        //    if (!updated)
        //        return NotFound();

        //    return NoContent();
        //}
    

    }
}
