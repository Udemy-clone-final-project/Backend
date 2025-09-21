using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace RedBubble.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly IAiService _aiService;

        public ChatController(IAiService aiService)
        {
            _aiService = aiService;
        }

        public class ChatRequest
        {
            [Required]
            public string Message { get; set; } = string.Empty;
        }

        public class ChatResponse
        {
            public string Reply { get; set; } = string.Empty;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<ChatResponse>> Post([FromBody] ChatRequest request, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }

            var userId = User?.Identity?.IsAuthenticated == true ? User.Identity!.Name : null;
            var reply = await _aiService.GenerateChatResponseAsync(request.Message, userId, cancellationToken);
            return Ok(new ChatResponse { Reply = reply });
        }
    }
}


