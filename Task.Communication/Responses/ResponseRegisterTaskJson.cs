using Task.Communication.Enums;

namespace Task.Communication.Responses;

public class ResponseRegisterTaskJson
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriorityEnum Priority { get; set; }
    public DateTime DueDate { get; set; } 
    public TaskStatusEnum Status { get; set; }
}
