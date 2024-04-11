using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Mini_Project.Data;
using Mini_Project.Dto;
using Mini_Project.Models;
using Mini_Project.Models.Interfaces;

namespace Mini_Project.Repository
{
    public class UserRepository : IUser
    {
        private readonly AppConfigDBContext _appConfigDBContext;
        private readonly IMapper _mapper;

        public UserRepository(AppConfigDBContext appConfigDBContext,IMapper mapper)
        {
            _appConfigDBContext = appConfigDBContext;
            _mapper = mapper;
        }

        public async Task AddUser(User user)
        {
            try
            {
                if (user == null) throw new ArgumentNullException(nameof(user));

                await _appConfigDBContext.Users.AddAsync(user);
                await _appConfigDBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while adding users: " + ex.Message);
            }
        }

        public async Task DeleteUser()
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserDto>> GetAllUsers() // Corrected return type
        {
            try
            {
                var users = await _appConfigDBContext.Users.ToListAsync();
                var usersDto = _mapper.Map<List<UserDto>>(users); // Map to List<UserDto>
                return usersDto;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while fetching users: " + ex.Message);
            }
        }

        public async Task UpdateUser()
        {
            throw new NotImplementedException();
        }
    }
}
