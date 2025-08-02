using RedBubble.Application.DTOs;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Services
{
    internal class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
       
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task CreateAsync(RoleDTO role)
        {
          

            var newRole = new ApplicationRole
            {
                Name = role.Name ,
                Description = role.Description 
            };
            
            await _roleRepository.CreateAsync(newRole);
        }

        public async Task<IEnumerable<ApplicationRole>> GetAllAsync()
        {
            return await _roleRepository.GetAllAsync();
        }

        public async Task<ApplicationRole> GetByIdAsync(string id)
        {
            return await _roleRepository.GetByIdAsync(id);
        }

        public async Task<ApplicationRole> GetByNameAsync(string name)
        {
            return await _roleRepository.GetByNameAsync(name);
        }


       

        public async Task UpdateAsync(RoleDTO role)
        {
           
            var updatedRole = await GetByNameAsync(role.Name);

            updatedRole.Name = role.Name;
            updatedRole.Description = role.Description;
            
            await _roleRepository.UpdateAsync(updatedRole);
        }

        public async Task DeleteAsync(string id)
        {
            var role = await _roleRepository.GetByIdAsync(id);

            await _roleRepository.DeleteAsync(role);
        }

        
    }
}
