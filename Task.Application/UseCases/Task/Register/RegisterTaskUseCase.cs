using Task.Application.Data;
using Task.Application.Entities;
using Task.Communication.Requests;
using Task.Communication.Responses;

namespace Task.Application.UseCases.Task.Register;

public class RegisterTaskUseCase
{
    public ResponseRegisterTaskJson Execute(RequestRegisterTaskJson request)
    {
        var task = new TaskModel
        {
            Id = Guid.NewGuid(),
            name = request.name,
            description = request.description,
            priority = request.priority,
            dueDate = request.dueDate,
            status = request.status,
        };

        TaskRepository.Add(task);

        return new ResponseRegisterTaskJson
        {
            Id = task.Id,
            name = task.name,
            description = task.description,
            priority = task.priority,
            dueDate = task.dueDate,
            status = task.status,
        };
    }
}
