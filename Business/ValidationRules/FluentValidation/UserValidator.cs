using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        IUserDal userDal = new EfUserDal();
        public UserValidator()
        {
            RuleFor(u => u.Email).EmailAddress();
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Email).Must(uniqueEmail).WithMessage("Kayıt olduğunuz email zaten sistemde kayıtlı");

        }

        private bool uniqueEmail(string arg)
        {
            var result = userDal.GetAll();
            var email = result.Find(e => e.Email == arg);
            if (email == null) return true;
            else return false;
            }
    }
}