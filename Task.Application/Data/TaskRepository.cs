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
}
