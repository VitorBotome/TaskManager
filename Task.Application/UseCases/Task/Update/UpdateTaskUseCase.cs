using Task.Application.Data;
using Task.Communication.Requests;

namespace Task.Application.UseCase.Task.Update;

public class UpdateTaskUseCase
{
    public void Execute(Guid id,RequestUpdateTaskJson request)
    {
        
        var task = TaskRepository.GetTaskById(id);

        if (task == null)
        {
            throw new ArgumentException($"Task nao encontrada");
        }

        task.name = request.name;
        task.description = request.description;
        task.priority = request.priority;
        task.dueDate = request.dueDate;
        task.status = request.status;

        TaskRepository.UpdateTask();
    }
}
