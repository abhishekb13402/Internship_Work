using Microsoft.AspNetCore.Identity.Data;
using Mini_Project.Models;
namespace Mini_Project.Models.Interfaces
{
    public interface IAuthService
    {
        User AddUser(User user);
        string Login(LoginRequest loginRequest);
        Role AddRole(Role role);
        bool AssignRoleToUser(AddUserRole obj);

    }
}
