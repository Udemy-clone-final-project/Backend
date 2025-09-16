//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using RedBubble.Application.DTOs.Design;
//using RedBubble.Application.Interfaces;
//using RedBubble.Application.Services;
//using RedBubble.Domain.Entities.Models;
//using System.Net;
//using System.Security.Cryptography;
//using System.Security.Principal;

//namespace RedBubble.WebAPI.Controllers.DesignControllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ArtistDesignController : ControllerBase
//    {
//        private readonly IDesignService _designService;
//        private readonly UserManager<ApplicationUser> _userManager;

//        public ArtistDesignController(IDesignService designService, UserManager<ApplicationUser> userManager)
//        {
//            _designService = designService;
//            _userManager = userManager;
//        }

//        // Hardcoded artist ID (just for testing — remove later)
//        //Guid artistId = Guid.Parse("9E85ED5F-9443-4471-888B-EE5A26E8A45D");


//        [HttpPost]
//        public async Task<IActionResult> Create(ArtistDesignDTO artistDesignDTO)
//        {
//            //var user = await _userManager.GetUserAsync(User); // get the logged-in user



//            //if (user == null)
//            //    return Unauthorized("You must be logged in to create a design.");
//            await _designService.CreateAsync(artistDesignDTO, artistId);
//            return Ok();
//        }

//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<ArtistGetDesignDTO>>> GetAll()
//        {

//            var designs = await _designService.GetAllAsync(artistId);

//            return Ok(designs);
//        }

//        [HttpPut("{id}")]
//        public async Task<IActionResult> Update(ArtistDesignDTO artistDesignDTO , int designId)
//        {
//           await _designService.Update(artistDesignDTO, designId);

//            return Ok();
//        }
//        // 788D3D1F-8F2C-4962-0BC9-08DDD4165F77

//        #region how update works ?
//        //Do it in two requests(Best Practice)
//        //If you're building a UI later or using something like Postman:

//        //GET /api/ArtistDesign/{id} → returns the old data
//        //Show the form(e.g., on web or mobile)
//        //User edits and submits
//        //PUT /api/ArtistDesign/{id} → sends the updated data
//        //This is the correct flow in every real app.
//        #endregion


//        #region why we not send the whole use , so we can in service make artist = user ?
//        //Great question — here's why we don’t send the whole user object when creating something like a design:

//        //Why We Don’t Send the Whole User Object

//        //Security Risk
//        //A user could manipulate the request body and change properties like Id, Email, Roles, etc. That would let them pretend to be someone else.

//        //Overposting Attack
//        //If your API accepts the entire user object, a malicious user could include sensitive or unintended fields and affect data they shouldn’t have access to.

//        //Redundant and Unnecessary
//        //The backend can already identify the logged-in user using the authentication token(JWT or cookie). So there’s no need to send the user manually from the client.

//        #endregion

//    }
//}
