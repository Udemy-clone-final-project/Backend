using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.Interfaces;

namespace RedBubble.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public HomeController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        /// <summary>
        /// Gets home page data including featured products, categories, and designs
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetHomeData()
        {
            try
            {
                // Get featured products (recent product variants)
                var featuredProducts = await _serviceManager.productVariantService.GetAllProductVariantsAsync(
                    searchItem: null, 
                    sortColumn: "CreatedOn", 
                    sortOrder: "desc", 
                    categoryId: null, 
                    page: 1, 
                    pageSize: 15
                );

                // Get categories
                var categories = await _serviceManager.categoryService.GetAllAsync();

                // Get featured designs
                var featuredDesigns = await _serviceManager.designService.GetAllAsync(
                    searchItem: null, 
                    sortColumn: "CreatedOn", 
                    sortOrder: "desc", 
                    page: 1, 
                    pageSize: 10
                );

                var homeData = new
                {
                    FeaturedProducts = featuredProducts,
                    Categories = categories,
                    FeaturedDesigns = featuredDesigns,
                    Stats = new
                    {
                        TotalProducts = featuredProducts.TotalCount,
                        TotalCategories = categories.Count(),
                        TotalDesigns = featuredDesigns.TotalCount
                    }
                };

                return Ok(homeData);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Gets featured products for the home page
        /// </summary>
        [HttpGet("featured-products")]
        public async Task<IActionResult> GetFeaturedProducts(int count = 15)
        {
            try
            {
                var products = await _serviceManager.productVariantService.GetAllProductVariantsAsync(
                    searchItem: null, 
                    sortColumn: "CreatedOn", 
                    sortOrder: "desc", 
                    categoryId: null, 
                    page: 1, 
                    pageSize: count
                );

                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Gets categories for navigation
        /// </summary>
        [HttpGet("categories")]
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                var categories = await _serviceManager.categoryService.GetAllAsync();
                return Ok(categories);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
