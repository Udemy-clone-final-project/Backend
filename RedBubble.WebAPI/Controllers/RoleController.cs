//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using RedBubble.Application.DTOs;
//using RedBubble.Application.Interfaces;
//using RedBubble.Domain.Entities.Models;
//using System.Threading.Tasks;

//namespace RedBubble.WebAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class RoleController : ControllerBase
//    {
//        private readonly IRoleService _roleService;

//        public RoleController(IRoleService roleService)
//        {
//            _roleService = roleService;
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetAllRoles()
//        {
//            var roles =  await _roleService.GetAllAsync();

//            return Ok(roles);
//        }

//        [HttpGet("id/{id}")]
//        public async Task<IActionResult> GetRoleById(string id)
//        {
//            var role = await _roleService.GetByIdAsync(id);

//            return Ok(role);
//        }

//        [HttpGet("name/{name}")]
//        public async Task<IActionResult> GetRoleByName(string name)
//        {
//            var role = await _roleService.GetByNameAsync(name);

//            return Ok(role);
//        }

//        [HttpPost]
//        public async Task<IActionResult> CreateRole([FromBody] RoleDTO role)
//        {
            

//            await _roleService.CreateAsync(role);

//            return Ok();
//        }

//        [HttpPut]
//        public async Task<IActionResult> UpdateRole([FromBody]RoleDTO role)
//        {
            
//           await _roleService.UpdateAsync(role);

//            return Ok();
//        }

//        [HttpDelete]
//        public async Task<IActionResult> DeleteRole(string id)
//        {

//           await _roleService.DeleteAsync(id);

//            return Ok();
//        }

//    }
//}
