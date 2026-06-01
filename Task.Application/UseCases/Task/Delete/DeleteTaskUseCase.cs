using Task.Application.Data;

namespace Task.Application.UseCases.Task.Delete;

public class DeleteTaskUseCase
{
    public void Execute(Guid id)
    {
        var task = TaskRepository.GetTaskById(id);
        

        if (task == null)
        {
            throw new ArgumentException($"Task nao encontrada");
        }
        TaskRepository.Delete(task);
    }
}
