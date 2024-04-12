namespace Mini_Project.Models.Interfaces
{
    public class AddUserRole
    {
        public int UserId{ get; set; }
        public List<int> RoleIds { get; set;}
    }
}