using Task.Application.Data;
using Task.Communication.Responses;

namespace Task.Application.UseCases.Task.GetAllTasks;

public class GetAllTasksUseCase
{
    public List<ResponseShortTaskJson> Execute()
    {
        var tasks = TaskRepository.GetAll();

        return tasks.Select(task => new ResponseShortTaskJson
        {
            name = task.name,
            description = task.description,
            priority = task.priority,
            dueDate = task.dueDate,
            status = task.status
        }).ToList();
    }
}
