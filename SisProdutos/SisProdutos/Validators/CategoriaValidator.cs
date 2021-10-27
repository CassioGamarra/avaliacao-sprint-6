using FluentValidation;
using SisProdutos.DTOs;

namespace SisProdutos.Validators
{
    public class CategoriaValidator : AbstractValidator<CategoriaDTO>
    {
        public CategoriaValidator()
        {
            RuleFor(categoria => categoria.Descricao).NotEmpty().WithMessage("Por favor, a descrição"); 
        }
    }
}