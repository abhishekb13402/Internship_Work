using System.ComponentModel.DataAnnotations;

namespace Mini_Project.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
