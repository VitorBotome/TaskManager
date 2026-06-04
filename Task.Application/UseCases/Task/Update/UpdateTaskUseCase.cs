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

        task.Name = request.Name;
        task.Description = request.Description;
        task.Priority = request.Priority;
        task.DueDate = request.DueDate;
        task.Status = request.Status;

        TaskRepository.UpdateTask();
    }
}
