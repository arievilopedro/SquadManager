using FluentValidation;
using SquadManager.Models;

namespace SquadManager.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator() 
        {
            RuleFor(user => user.Email).NotNull().WithMessage("E-mail Vazio");
            RuleFor(user => user.Email).EmailAddress().WithMessage("E-mail Inválido");
            RuleFor(user => user.UserName).NotNull().WithMessage("Digite a Senha");
            RuleFor(user => user.Password).NotNull();
        }
    }
}
