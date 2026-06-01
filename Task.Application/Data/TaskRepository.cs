using Task.Application.Entities;

namespace Task.Application.Data;

public class TaskRepository
{
    private static List<TaskModel> _tasks = new();

    public static void Add(TaskModel task)
    {
        _tasks.Add(task);
    }

    public static List<TaskModel> GetAll()
    {
        return _tasks;
    }

    public static TaskModel? GetTaskById(Guid id)
    {
        return _tasks.Find(task => task.Id == id);
    }
    public static void UpdateTask()
    {
        
    }
    public static void Delete(TaskModel task)
    {
        _tasks.Remove(task);
    }
}
