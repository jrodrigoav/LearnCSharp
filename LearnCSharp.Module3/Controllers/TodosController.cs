using FluentValidation;
using FluentValidation.AspNetCore;
using LearnCSharp.Module3.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace LearnCSharp.Module3.Controllers
{
    [Route("api/todos"), ApiController]
    public class TodosController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateTodo(CreateTodoRequest model, [FromServices] IValidator<CreateTodoRequest> validationRules)
        {
            var result = await validationRules.ValidateAsync(model);
            if (result.IsValid)
            {
                return Created("api/todos", null);
            }
            else
            {
                result.AddToModelState(ModelState);
                return BadRequest(ModelState);
            }
        }
    }
}
