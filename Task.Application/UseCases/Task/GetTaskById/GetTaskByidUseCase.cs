using Task.Application.Data;
using Task.Application.Entities;

namespace Task.Application.UseCases.Task.GetTaskById;

public class GetTaskByidUseCase
{
    public TaskModel Execute(Guid id)
    {
        var task = TaskRepository.GetTaskById(id);

        return task;
    }
}
