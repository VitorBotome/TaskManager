using Microsoft.AspNetCore.Mvc;
using Task.Application.UseCase.Task.Update;
using Task.Application.UseCases.Task.Delete;
using Task.Application.UseCases.Task.GetAllTasks;
using Task.Application.UseCases.Task.GetTaskById;
using Task.Application.UseCases.Task.Register;
using Task.Communication.Requests;
using Task.Communication.Responses;

namespace TaskManagerApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErroJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestRegisterTaskJson request)
    {
        var response = new RegisterTaskUseCase().Execute(request);
        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<ResponseShortTaskJson>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAllTasks()
    {
        var useCase = new GetAllTasksUseCase();
        var response = useCase.Execute();

        if (response == null || response.Count == 0)
        {
            return NoContent();
        }
        return Ok(response);
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetTaskById([FromRoute]Guid id)
    {
        var useCase = new GetTaskByidUseCase();
        var response = useCase.Execute(id);

        if (response == null)
        {
            return NoContent();
        }
        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErroJson), StatusCodes.Status404NotFound)]
    public IActionResult UpdateTask([FromRoute] Guid id,[FromBody] RequestUpdateTaskJson request)
    {
        try
        {
            var useCase = new UpdateTaskUseCase();
            useCase.Execute(id, request);

            return NoContent();
        }
        catch (ArgumentException ex)
        {
            return NotFound(new ResponseErroJson { Errors = new List<string> { ex.Message } });
        }
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErroJson), StatusCodes.Status404NotFound)]
    public IActionResult DeleteTaskById(Guid id)
    {
        try
        {
            var useCase = new DeleteTaskUseCase();
            useCase.Execute(id);

            return NoContent();
        }
        catch (ArgumentException ex)
        {
            return NotFound(new ResponseErroJson { Errors = new List<string> { ex.Message } });
        }
    }
}
