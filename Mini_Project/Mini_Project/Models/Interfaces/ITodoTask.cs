using Mini_Project.Dto;

namespace Mini_Project.Models.Interfaces
{
    public interface ITodoTask
    {
        Task<List<TodoTaskDto>> GetAllTasks();
        Task AddTask(TodoTask todoTask);
        Task<object> Updatetask(TodoTaskDto todoTaskDto);
        Task<object> DeleteTask(int id);
    }
}
