using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class FundValidator : AbstractValidator<Fund>
    {
        public FundValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
            RuleFor(x => x.Amount).NotEmpty();
            RuleFor(x => x.FundName).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Date).NotEmpty();
        }

    }
}