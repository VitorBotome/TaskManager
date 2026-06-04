using Task.Application.Data;
using Task.Application.Entities;
using Task.Application.UseCases.TaskValidator;
using Task.Communication.Requests;
using Task.Communication.Responses;

namespace Task.Application.UseCases.Task.Register;

public class RegisterTaskUseCase
{
    public ResponseRegisterTaskJson Execute(RequestRegisterTaskJson request)
    {

        ValidateTask.ValidatePriority(request.Priority);
        ValidateTask.ValidateStatus(request.Status);

        if (request.DueDate.Date <= DateTime.UtcNow.Date) //verifica se a data e maior que a data atual
        {
            throw new ArgumentException("A data deve ser futura");
        }

        var task = new TaskModel
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            DueDate = request.DueDate,
            Status = request.Status,
        };

        TaskRepository.Add(task);

        return new ResponseRegisterTaskJson
        {
            Id = task.Id,
            Name = task.Name,
            Description = task.Description,
            Priority = task.Priority,
            DueDate = task.DueDate,
            Status = task.Status,
        };
    }
}
