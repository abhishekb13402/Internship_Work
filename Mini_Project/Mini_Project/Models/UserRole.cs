using System.ComponentModel.DataAnnotations;

namespace Mini_Project.Models
{
    public class UserRole
    {
        [Key]
        public int UserRoleId { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
    }
}
