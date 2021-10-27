using FluentValidation;
using SisProdutos.DTOs;

namespace SisProdutos.Validators
{
    public class CidadeValidator : AbstractValidator<CidadeDTO>
    {
        public CidadeValidator()
        {
            RuleFor(cidade => cidade.Nome).NotEmpty().WithMessage("Por favor, preencha o nome da cidade.");
            RuleFor(cidade => cidade.Estado).NotEmpty().WithMessage("Por favor, preencha o estado.");
        }
    }
}