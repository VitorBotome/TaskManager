using System.ComponentModel.DataAnnotations;
using Task.Communication.Enums;

namespace Task.Communication.Requests;

public class RequestUpdateTaskJson
{
    [Required(ErrorMessage = "O nome da Tarefa é obrigatório.")]
    [MaxLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres.")]
    public string Name { get; set; } = string.Empty;
    [MaxLength(500, ErrorMessage = "A descrição não pode ter mais que 500 caracteres.")]
    public string? Description { get; set; }
    public TaskPriorityEnum Priority { get; set; }
    public DateTime DueDate { get; set; }
    public TaskStatusEnum Status { get; set; }
}
