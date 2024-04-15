using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mini_Project.Dto;
using Mini_Project.Models;
using Mini_Project.Models.Interfaces;
using Mini_Project.Repository;

namespace Mini_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoTaskController : ControllerBase
    {
        private readonly ITodoTask _todoTaskRepo;

        public TodoTaskController(ITodoTask todoTask)
        {
            _todoTaskRepo = todoTask;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<TodoTaskDto>>> GetAllTasks()
        {
            try
            {
                var tasks = await _todoTaskRepo.GetAllTasks();
                return Ok(tasks);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error occurred while fetching tasks: " + ex.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<TodoTaskDto>> AddTask(TodoTask todoTask)
        {
            try
            {
                await _todoTaskRepo.AddTask(todoTask);
                return Ok(todoTask);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error occurred while adding a task: " + ex.Message);
            }
        }

        [HttpDelete]
        [Authorize]
        public async Task<ActionResult<TodoTaskDto>> DeleteTask(int id)
        {
            try
            {
                await _todoTaskRepo.DeleteTask(id);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error occurred while deleting a task: " + ex.Message);
            }
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<TodoTaskDto>> UpdateTask(TodoTaskDto todoTaskDto)
        {
            try
            {
                await _todoTaskRepo.Updatetask(todoTaskDto);
                return Ok(todoTaskDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error occurred while updating a task: " + ex.Message);
            }
        }


    }
}
