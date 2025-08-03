using RedBubble.Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces
{
    public interface IUserService
    {
        Task<LoginResponseDTO> RegisterAsync(AccountCreateDTO dto);

        Task<LoginResponseDTO> LoginAsync(AccountLoginDTO dto);

        Task UpdateUserAsync(AccountUpdateDTO dto);

        Task ChangePasswordAsync(ChangePasswordDTO dto);
         
        Task<UserDTO> GetUserByIdAsync(Guid id);

        Task<IEnumerable<UserDTO>> GetAllUsersAsync();
    }
}
