using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs.User
{
    public class ChangePasswordDTO
    {
        public Guid Id { get; set; } 
        public string CurrentPassword { get; set; } 
        public string NewPassword { get; set; } 
        public string ConfirmNewPassword { get; set; } 
    }
}
