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
        //private readonly IDesignService _designService;

        //public DesignController(IDesignService designService)
        //{
        //    _designService = designService;
        //}

        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    var designs =  await _designService.GetAllAsync();
        //    return Ok(designs);
        //}

        //[HttpPost]
        //public async Task Create(Design design)
        //{
        //    await _designService.CreateAsync(design);
        //}
    }
}
