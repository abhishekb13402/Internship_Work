using System.ComponentModel.DataAnnotations;

namespace Relationship.Models
{
    public class Manager
    {
        [Key]
        public int ManagerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //ome to many
        public ICollection<Employee> Employees { get; set; } //collection navigation property
    }
}
