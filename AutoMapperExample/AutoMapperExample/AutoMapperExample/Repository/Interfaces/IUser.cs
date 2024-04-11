using AutoMapperExample.Dto;

namespace AutoMapperExample.Repository.Interfaces
{
    public interface IUser
    {
        Task<UserDto> AddUser(UserDto userDto);
        Task<UserDto> UpdateUser(UserDto userDto);
        Task<UserDto> DeleteUser(UserDto userDto);
        Task<UserDto> GetUserById(UserDto userDto);
        Task<UserDto> GetAllUser(UserDto userDto);
        Task<UserDto> GetUserByEmail(UserDto userDto);
    }
}
