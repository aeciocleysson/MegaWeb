using FluentValidation;
using MegaWeb.Shared.Request;

namespace MegaWeb.Server.Validators
{
    public class FuncaoValidator : AbstractValidator<FuncaoRequest>
    {
        public FuncaoValidator()
        {
            RuleFor(r => r.Descricao)
                .NotEmpty()
                    .WithMessage("A Descrição deve ser preenchida.")
                .MinimumLength(2)
                    .WithMessage("Digite no minimo 2 caractéries")
                .MaximumLength(50)
                    .WithMessage("Digite no máximo 50 caractéries");
        }
    }
}