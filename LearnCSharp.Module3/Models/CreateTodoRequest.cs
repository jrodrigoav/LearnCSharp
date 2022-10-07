using FluentValidation;

namespace LearnCSharp.Module3.Models
{
    public class CreateTodoRequest : AbstractValidator<Todo>
    {
        public CreateTodoRequest()
        {
            RuleFor(model => model.Id).NotEmpty();
            RuleFor(model => model.UserId).NotEmpty().ToString();   
            RuleFor(model => model.Title).ToString();
            RuleFor(model => model.Completed).ToString();
        }
    }
}
