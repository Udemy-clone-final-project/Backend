namespace RedBubble.Dashboard.Models
{
    public class UserRoleViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public List<RoleViewModel> Roles { get; set; }
    }
}
