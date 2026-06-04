using Task.Communication.Enums;

namespace Task.Communication.Responses;

public class ResponseShortTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriorityEnum Priority { get; set; }
    public DateTime DueDate { get; set; }
    public TaskStatusEnum Status { get; set; }
}

