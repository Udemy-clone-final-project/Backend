using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.DTOs.Design;
using RedBubble.Application.Interfaces;

namespace RedBubble.WebAPI.Controllers.DesignControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminDesignController : ControllerBase
    {
        private readonly IDesignService _designService;
        public AdminDesignController(IDesignService designService)
        {
            _designService = designService;
        }
    }
}
