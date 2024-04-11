using AutoMapper;
using AutoMapperExample.DBContext;
using AutoMapperExample.Dto;
using AutoMapperExample.Repository.Interfaces;

namespace AutoMapperExample.Repository
{
    public class UserRepository : IUser
    {
        private readonly IMapper _mapper;
        private readonly AppConfigDBContext appConfigDBContext;
        private readonly IUser _user;

        public UserRepository(IUser user, AppConfigDBContext appConfigDBContext,IUser _user)
        {
            _user = user;
            this.appConfigDBContext = appConfigDBContext;
            this._user = _user;
        }

        public Task<UserDto> AddUser(UserDto userDto)
        {
            return _user.AddUser(userDto);
        }

        public Task<UserDto> DeleteUser(UserDto userDto)
        {
            return _user.DeleteUser(userDto);
        }

        public Task<UserDto> GetAllUser(UserDto userDto)
        {
            return _user.GetAllUser(userDto);
        }

        public Task<UserDto> GetUserByEmail(UserDto userDto)
        {
            return _user.GetUserByEmail(userDto);
        }

        public Task<UserDto> GetUserById(UserDto userDto)
        {
            return _user.GetUserById(userDto);
        }

        public Task<UserDto> UpdateUser(UserDto userDto)
        {
            return _user.UpdateUser(userDto);
        }
    }
}
