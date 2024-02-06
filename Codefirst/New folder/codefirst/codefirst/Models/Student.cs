using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace codefirst.Models
{
    [Table("StudentTable")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("Student_Name", TypeName ="varchar(10)")]
        public string Name { get; set; }
        [Required]
        [Column("Student_Gender", TypeName = "varchar(10)")]
        public string Gender { get; set; }
        [Column("Student_Age")]
        public int Age { get; set; }
        public string Standard { get; set; }
    }
}
