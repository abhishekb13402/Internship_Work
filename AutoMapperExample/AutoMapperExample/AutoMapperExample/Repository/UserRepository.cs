using AutoMapper;
using AutoMapperExample.DBContext;
using AutoMapperExample.Dto;
using AutoMapperExample.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperExample.Repository
{
    public class UserRepository : IUser
    {
        private readonly IMapper _mapper;
        private readonly AppConfigDBContext appConfigDBContext;
        private readonly IUser _user;
        private readonly UserDto _userDto;

        public UserRepository(IUser user, AppConfigDBContext appConfigDBContext, UserDto userDto)
        {
            _user = user;
            this.appConfigDBContext = appConfigDBContext;
            _userDto = userDto;
        }

        public Task<UserDto> AddUser(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> DeleteUser(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDto> GetAllUser(UserDto userDto)
        {
            //var users = await appConfigDBContext.users.ToListAsync();
            //var usersDto = _mapper.Map<List<UserDto>>(users);
            //return usersDto.ToList();
            throw new NotImplementedException();

        }

        public Task<UserDto> GetUserByEmail(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetUserById(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> UpdateUser(UserDto userDto)
        {
            throw new NotImplementedException();
        }
    }
}
