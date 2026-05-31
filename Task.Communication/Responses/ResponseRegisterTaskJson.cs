using Task.Communication.Enums;

namespace Task.Communication.Responses;

public class ResponseRegisterTaskJson
{
    public Guid Id { get; set; }
    public string name { get; set; } = string.Empty;
    public string description { get; set; } = string.Empty;
    public TaskPriorityEnum priority { get; set; }
    public DateTime dueDate { get; set; }
    public TaskStatusEnum status { get; set; }
}
