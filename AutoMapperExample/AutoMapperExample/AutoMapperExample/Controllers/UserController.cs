using AutoMapper;
using AutoMapperExample.DBContext;
using AutoMapperExample.Dto;
using AutoMapperExample.Repository;
using AutoMapperExample.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppConfigDBContext appConfigDBContext;
        private readonly IUser _user;
        private readonly UserRepository _userRepository;
        private readonly UserDto userDto;

        public UserController(IUser _user, AppConfigDBContext appConfigDBContext, UserRepository userRepository,UserDto userDto)
        {
            this._user = _user;
            this.appConfigDBContext = appConfigDBContext;
            _userRepository = userRepository;
            this.userDto = userDto;
        }

        //[HttpGet]
        //public Task<object> GetAllUser()
        //{
        //    try
        //    {
        //        return _userRepository.GetAllUser();
        //    }catch(Exception ex)
        //    {
        //        throw new Exception("Error in Get All User");
        //    }
        //}

        // GET: api/Users
        
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        //{
        //   return _userRepository.GetAllUser(userDto);
        //}





    }
}
