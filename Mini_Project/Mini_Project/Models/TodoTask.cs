using System.ComponentModel.DataAnnotations;

namespace Mini_Project.Models
{
    public class TodoTask
    {
        [Key]
        public int TaskId { get; set; }
        public string Text { get; set; }
        public bool Status { get; set; }
    }
}
