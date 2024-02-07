using System.ComponentModel.DataAnnotations;

namespace Relationship.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Salary { get; set; }

        //one to one
        public EmployeeDetails EmployeeDetails{ get; set; } //reference navigation to 

        //one to many
        public int ManagerId { get; set; } //FK

        public Manager Manager{ get; set; }
    }
}
