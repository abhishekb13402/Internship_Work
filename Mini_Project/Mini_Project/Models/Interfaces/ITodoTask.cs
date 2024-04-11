using Mini_Project.Dto;

namespace Mini_Project.Models.Interfaces
{
    public interface ITodoTask
    {
        Task<List<UserDto>> GetAllTasks();
        Task AddTask(User user);
        Task Updatetask();
        Task DeleteTask();
    }
}
