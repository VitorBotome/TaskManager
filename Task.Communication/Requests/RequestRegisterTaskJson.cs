using System.ComponentModel.DataAnnotations;
using Task.Communication.Enums;

namespace Task.Communication.Requests;

public class RequestRegisterTaskJson
{
    [Required(ErrorMessage = "O nome da Tarefa é obrigatório.")]
    [MaxLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres.")]
    public string name { get; set; } = string.Empty;
    [MaxLength(500, ErrorMessage = "A descrição não pode ter mais que 500 caracteres.")]
    public string? description { get; set; }
    public TaskPriorityEnum priority { get; set; }
    public DateTime dueDate { get; set; }
    public TaskStatusEnum status { get; set; } 
}
