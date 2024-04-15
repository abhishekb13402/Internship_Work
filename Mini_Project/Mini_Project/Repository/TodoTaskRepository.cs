using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Mini_Project.Data;
using Mini_Project.Dto;
using Mini_Project.Models;
using Mini_Project.Models.Interfaces;

namespace Mini_Project.Repository
{
    public class TodoTaskRepository : ITodoTask
    {
        private readonly AppConfigDBContext _appConfigDBContext;
        private readonly IMapper _mapper;
        public TodoTaskRepository(AppConfigDBContext appConfigDBContext,IMapper mapper)
        {
            _appConfigDBContext = appConfigDBContext;
            _mapper = mapper;
        }
        public async Task AddTask(TodoTask todoTask)
        {
            try
            {
                if (todoTask == null) throw new ArgumentNullException(nameof(todoTask));

                await _appConfigDBContext.TodoTasks.AddAsync(todoTask);
                await _appConfigDBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while adding task: " + ex.Message);
            }
        }

        public async Task<object> DeleteTask(int id)
        {
            try
            {
                var DeleteTaskChoice = _appConfigDBContext.TodoTasks.FindAsync(id);
                if(DeleteTaskChoice == null) 
                { 
                    return false; 
                } 
                else
                {
                    _appConfigDBContext.TodoTasks.Remove(await DeleteTaskChoice);
                    await _appConfigDBContext.SaveChangesAsync();
                    return true;

                }
            }catch (Exception ex)
            {
                throw new Exception("Error occurred while deleting the task: " + ex.Message);
            }
        }

        public async Task<List<TodoTaskDto>> GetAllTasks()
        {
            try
            {
                var tasks = await _appConfigDBContext.TodoTasks.ToListAsync();
                var todotaskdto = _mapper.Map<List<TodoTaskDto>>(tasks);
                return todotaskdto;
            }catch (Exception ex)
            {
                throw new Exception("Error occured while fetching Taks: "+ex.Message);
            }
        }

        public async Task<object> Updatetask(TodoTaskDto todoTaskDto)
        {
            try
            {
                var existingTask = await _appConfigDBContext.TodoTasks.FindAsync(todoTaskDto.TaskId);
                if (existingTask == null)
                {
                    return false;
                }
                else
                {
                    _mapper.Map(todoTaskDto, existingTask);
                    await _appConfigDBContext.SaveChangesAsync();
                    var updatedTaskDto = _mapper.Map<TodoTaskDto>(existingTask);
                    return updatedTaskDto;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while updating the task: " + ex.Message);
            }
        }
    }
}
