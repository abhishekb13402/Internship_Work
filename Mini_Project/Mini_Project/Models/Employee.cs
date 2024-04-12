using System.ComponentModel.DataAnnotations;

namespace Mini_Project.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Company{ get; set; }
        public string Position { get; set; }

    }
}
