using FluentValidation;
using FluentValidation.Results;
using LearnCSharp.Module3.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LearnCSharp.Module3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly IValidator<Todo> _validator;

        public TodosController(IValidator<Todo> validator)
        {
            _validator = validator;
        }
        

        [HttpPost]
       public async Task<IActionResult> CreatedTodo(CreateTodoRequest createTodoRequest)
        {
            var result = await _validator.ValidateAsync((IValidationContext)createTodoRequest);
        if(result.IsValid)
            {
                return Created("api/jsonplaceholder/todo", null);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
