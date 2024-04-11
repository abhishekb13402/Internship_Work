using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mini_Project.Data;
using Mini_Project.Repository;
using Mini_Project.Models;
using Mini_Project.Dto;
using Mini_Project.Models.Interfaces;
using AutoMapper;

namespace Mini_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _userRepository;

        public UserController(IUser userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAllUsers()
        {
            try
            {
                var users = await _userRepository.GetAllUsers();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error occurred while fetching users: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> AddUser(User user)
        {
            try
            {
                await _userRepository.AddUser(user);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error occurred while adding a user: " + ex.Message);
            }
        }




    }
}
