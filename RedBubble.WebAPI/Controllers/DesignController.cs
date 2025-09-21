using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models;

namespace RedBubble.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public DesignController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        /// <summary>
        /// Gets all active designs with pagination
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllDesigns(int page = 1, int pageSize = 20)
        {
            try
            {
                var designs = await _serviceManager.designService.GetAllAsync(
                    searchItem: null, 
                    sortColumn: "CreatedOn", 
                    sortOrder: "desc", 
                    page: page, 
                    pageSize: pageSize
                );
                return Ok(designs);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Gets featured designs (most popular/recent)
        /// </summary>
        [HttpGet("featured")]
        public async Task<IActionResult> GetFeaturedDesigns(int count = 10)
        {
            try
            {
                var designs = await _serviceManager.designService.GetAllAsync(
                    searchItem: null, 
                    sortColumn: "CreatedOn", 
                    sortOrder: "desc", 
                    page: 1, 
                    pageSize: count
                );
                return Ok(designs);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Gets a design by ID
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDesignById(int id)
        {
            try
            {
                var design = await _serviceManager.designService.GetDesignByIdAsync(id);
                return Ok(design);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
