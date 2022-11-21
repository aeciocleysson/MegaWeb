using FluentValidation;
using MegaWeb.Shared.Request;

namespace MegaWeb.Shared.Validation
{
    public class FuncaoValidator : AbstractValidator<FuncaoRequest>
    {
        public FuncaoValidator()
        {
            RuleFor(x => x.Descricao).NotEmpty().WithMessage("Descrição é obrigatório.");
            RuleFor(x => x.Descricao).NotEmpty().Length(2,50).WithMessage("Descrição deve ter no minimo 2 caracteres e no maximo 50 caracteres.");
        }
    }
}