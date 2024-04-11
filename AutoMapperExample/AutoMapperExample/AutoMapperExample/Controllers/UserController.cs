using AutoMapper;
using AutoMapperExample.DBContext;
using AutoMapperExample.Dto;
using AutoMapperExample.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppConfigDBContext appConfigDBContext;
        private readonly IUser _user;

        public UserController(IUser user, AppConfigDBContext appConfigDBContext, IUser _user)
        {
            _user = user;
            this.appConfigDBContext = appConfigDBContext;
            this._user = _user;
        }

        [HttpGet]
        public Task<object> GetAllUser(UserDto userDto)
        {
            try
            {
                return _user.GetAllUser(userDto);
            }catch(Exception ex)
            {
                throw new Exception("Error in Get All User");
            }
        }






    }
}
