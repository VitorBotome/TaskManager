using Task.Communication.Enums;

namespace Task.Application.UseCases.TaskValidator;

public class ValidateTask
{
    public static void ValidatePriority(TaskPriorityEnum priority)
    {
        if (!Enum.IsDefined(typeof(TaskPriorityEnum), priority))
        {
            throw new ArgumentException("Prioridade Invalida.");
        }
    }

    public static void ValidateStatus(TaskStatusEnum status)
    {
        if (!Enum.IsDefined(typeof(TaskStatusEnum), status))
        {
            throw new ArgumentException("Status invalido.");
        }
    }
}
