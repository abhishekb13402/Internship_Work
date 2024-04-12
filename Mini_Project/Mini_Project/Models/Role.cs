using System.ComponentModel.DataAnnotations;

namespace Mini_Project.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
