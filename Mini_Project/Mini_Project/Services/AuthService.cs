using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Mini_Project.Data;
using Mini_Project.Models;
using Mini_Project.Models.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Mini_Project.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppConfigDBContext appConfigDBContext;
        private readonly IConfiguration configuration;

        public AuthService(AppConfigDBContext appConfigDBContext, IConfiguration configuration)
        {
            this.appConfigDBContext = appConfigDBContext;
            this.configuration = configuration;
        }

        public Role AddRole(Role role)
        {
            var addRole = appConfigDBContext.Roles.Add(role);
            appConfigDBContext.SaveChanges();
            return addRole.Entity;
        }

        public User AddUser(User user)
        {
            var addUser = appConfigDBContext.Users.Add(user);   
            appConfigDBContext.SaveChanges();
            return addUser.Entity;
        }

        public bool AssignRoleToUser(AddUserRole obj)
        {
            try
            {
                var addRoles = new List<UserRole>();
                var user = appConfigDBContext.Users.SingleOrDefault(s => s.UserId == obj.UserId);
                if (user == null) { throw new Exception("User is not valid"); }
                foreach(int role in obj.RoleIds)
                {
                    var useRole = new UserRole();
                    useRole.RoleId = role;
                    useRole.UserId = user.UserId;
                    addRoles.Add(useRole);
                }
                appConfigDBContext.UserRoles.AddRange(addRoles);
                appConfigDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;  
            }
            
        }


        public string Login(LoginRequest loginRequest)
        {
            if (loginRequest.UserEmail != null && loginRequest.Password != null)
            {
                var user = appConfigDBContext.Users.SingleOrDefault(s => s.Email == loginRequest.UserEmail && s.Password == loginRequest.Password);

                if (user != null)
                {
                    var claims = new List<Claim> {
                new Claim(JwtRegisteredClaimNames.Sub, configuration["Jwt:Subject"])
            };

                    if (user.Email != null)
                    {
                        claims.Add(new Claim("Email", user.Email));
                    }

                    if (user.Password != null)
                    {
                        claims.Add(new Claim("Password", user.Password));
                    }

                    var userRoles = appConfigDBContext.UserRoles.Where(u => u.UserId == user.UserId).ToList();
                    var roleIds = userRoles.Select(s => s.RoleId).ToList();
                    var roles = appConfigDBContext.Roles.Where(r => roleIds.Contains(r.RoleId)).ToList();
                    foreach (var role in roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role.RoleName));
                    }

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        configuration["Jwt:Issuer"],
                        configuration["Jwt:Audience"],
                        claims,
                        expires: DateTime.UtcNow.AddDays(1),
                        signingCredentials: signIn);

                    var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
                    return jwtToken;
                }
                else
                {
                    throw new Exception("User is not valid");
                }
            }
            else
            {
                throw new Exception("Credentials are not valid");
            }
        }




    }
}