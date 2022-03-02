using Domain.Entities;
using FluentValidation;

namespace Services.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage(" Por favor, digite o nome.")
                .NotNull().WithMessage(" Por favor, digite o nome.");

            RuleFor(c => c.SobreNome)
                .NotEmpty().WithMessage("Por favor, digite o sobreNome.")
                .NotNull().WithMessage("Por favor, digite o sobrenome.");

            RuleFor(c => c.Idade)
                .NotEmpty().WithMessage("Por favor, digite a idade.")
                .NotNull().WithMessage("Por favor, digite o idade.");
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Por favor, digite o e-mail.")
                .NotNull().WithMessage("Por favor, digite o e-mail.");
        }
    }
}
