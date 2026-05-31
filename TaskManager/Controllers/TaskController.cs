using Microsoft.AspNetCore.Mvc;
using Task.Application.UseCases.Task.Register;
using Task.Communication.Requests;

namespace TaskManagerApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterTaskJson request)
    {
        var response = new RegisterTaskUseCase().Execute(request);
        return Created();
    }
}
