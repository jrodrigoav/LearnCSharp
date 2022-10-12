using FluentValidation;
using FluentValidation.AspNetCore;
using LearnCSharp.Module3.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace LearnCSharp.Module3.Controllers
{
    [Route("api/todos"), ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodosService _service;

        public TodosController(ITodosService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetTodos()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreateTodo(CreateTodoRequest createTodoRequest, [FromServices] IValidator<CreateTodoRequest> validationRules)
        {
            var result = await validationRules.ValidateAsync(createTodoRequest);
            if (!result.IsValid)
            {
                result.AddToModelState(ModelState);
                return BadRequest(ModelState);
            }
            /// HERE GOES LOGIC
            ///  var todos = Array.Empty<Todo>();

            /// createTodoRequest.Contains(createTodoRequest) ???
           // if (/* model exists in api data */)
            //{
            //    return Conflict();
           // }

            /// HERE GOES LOGIC
            return Created("api/todos/", createTodoRequest);
        }
    }
}
