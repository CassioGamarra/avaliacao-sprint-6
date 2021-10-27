using FluentValidation;
using SisProdutos.DTOs;

namespace SisProdutos.Validators
{
    public class ProdutoValidator : AbstractValidator<ProdutoDTO>
    {
        public ProdutoValidator()
        {
            RuleFor(produto => produto.Categoria).NotEmpty().WithMessage("Por favor, selecione uma categoria.");
            RuleFor(produto => produto.Nome).NotEmpty().WithMessage("Por favor, preencha o nome.");
            RuleFor(produto => produto.Descricao).NotEmpty().WithMessage("Por favor, preencha a descrição.");
            RuleFor(produto => produto.Preco).NotEmpty().WithMessage("Por favor, preencha o preço.");
            RuleFor(produto => produto.PalavrasChaves).NotEmpty().WithMessage("Por favor, informe ao menos uma palavra-chave");
        }
    }
}