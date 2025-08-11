//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;
//using RedBubble.Domain.Entities.Models;
//using RedBubble.Domain.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Security.Principal;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Net.Mime.MediaTypeNames;

//namespace RedBubble.Infrastructure.Implementations.Repositories
//{
//    public class RoleRepository: IRoleRepository
//    {
//        // what is role manger , what is its job ?
//        //RoleManager<IdentityRole> is a service provided by ASP.NET Core Identity
//        //that allows you to create, update, delete, and manage roles in your application.

//        private readonly RoleManager<ApplicationRole> _roleManager;

//        public RoleRepository(RoleManager<ApplicationRole> roleManager)
//        {
//            _roleManager = roleManager;
//        }

//        public async Task CreateAsync(ApplicationRole role)
//        {
//            if (_roleManager == null)
//                throw new InvalidOperationException("_roleManager is not initialized");
//            var newRole = new ApplicationRole
//            {
//                Id = role.Id,
//                Name = role.Name,
//                Description = role.Description,

//            };

//            // where does it store the role , we used to make this context.add(role) to store the store in db  ?
//            // usually, we use context.Add(entity) and context.SaveChangesAsync() when working with Entity Framework directly.
//            // But in ASP.NET Core Identity, something else is happening under the hood.
//            // This method: Creates a new role , Saves it to the database , Uses the configured DbContext internally

//            // the line equals this 
//            //_context.Roles.Add(identityRole);
//            //await _context.SaveChangesAsync();
//            await _roleManager.CreateAsync(newRole);
//        }

//        public async Task<IEnumerable<ApplicationRole>> GetAllAsync()
//        {
//            return await _roleManager.Roles.ToListAsync();
//        }

//        public async Task<ApplicationRole> GetByIdAsync(string id)
//        {
//            var  role =  await _roleManager.FindByIdAsync(id);

//            if(role == null)
//            {
//                return null;
//            }

//            return role;
//        }

//        public async Task<ApplicationRole> GetByNameAsync(string name)
//        {
//            var role = await _roleManager.FindByNameAsync(name);

//            if (role == null)
//            {
//                return null;
//            }

//            return role;
//        }


//        public async Task UpdateAsync(ApplicationRole role)
//        {
           
//            await _roleManager.UpdateAsync(role);
//        }

//        public async Task DeleteAsync(ApplicationRole role)
//        {
//           await  _roleManager.DeleteAsync(role);
//        }


//    }
//}
