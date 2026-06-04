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
            Name = task.Name,
            Description = task.Description,
            Priority = task.Priority,
            DueDate = task.DueDate,
            Status = task.Status
        }).ToList();
    }
}
