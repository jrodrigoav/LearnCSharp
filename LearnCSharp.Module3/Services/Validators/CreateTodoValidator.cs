using FluentValidation;
using LearnCSharp.Module3.Models.DTO;

namespace LearnCSharp.Module3.Services.Validators
{
    public class CreateTodoRequestValidator : AbstractValidator<CreateTodoRequest>
    {
        public CreateTodoRequestValidator()
        {            
            RuleFor(model => model.UserId).InclusiveBetween(1, int.MaxValue).WithMessage("UserId must be >= 1");
            RuleFor(model => model.Title).MinimumLength(5).WithMessage("Title must be  at least 5 characters long");
        }
    }
}
