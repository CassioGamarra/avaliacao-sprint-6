using FluentValidation;
using SisClientes.DTOs;

namespace SisClientes.Validators
{
    public class EnderecoValidator : AbstractValidator<EnderecoDTO>
    {
        public EnderecoValidator()
        { 
            RuleFor(endereco => endereco.Numero).NotEmpty().WithMessage("Por favor, preencha o número do endereço."); 
            RuleFor(endereco => endereco.Logradouro).NotEmpty().WithMessage("Não foi possível encontrar o logradouro através do CEP, por favor, informe esse campo manualmente.");
            RuleFor(endereco => endereco.Bairro).NotEmpty().WithMessage("Não foi possível encontrar o bairro através do CEP, por favor, informe esse campo manualmente.");  
        }
    }
}