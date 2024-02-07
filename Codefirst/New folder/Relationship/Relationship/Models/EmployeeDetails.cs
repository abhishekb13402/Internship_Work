using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relationship.Models
{
    public class EmployeeDetails
    {
        [Key]
        public int id { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public int EmployeeId { get; set; } //Foreign key
        public Employee Employee { get; set; } //reference navigation property
    }
}
