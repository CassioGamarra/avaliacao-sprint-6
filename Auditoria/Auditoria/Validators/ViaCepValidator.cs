using FluentValidation;
using SisClientes.DTOs;

namespace SisClientes.Validators
{
    /*O validator do ViaCEP trabalha com o cliente DTO para validar o CEP enviado através da request*/
    public class ViaCepValidator : AbstractValidator<EnderecoDTO>
    {
        public ViaCepValidator()
        {
            RuleFor(viaCep => viaCep.Cep).NotEmpty().WithMessage("Por favor, preencha o CEP."); 
            RuleFor(viaCep => viaCep.Cep).Matches(@"^[0-9]{5}-?[0-9]{3}$").WithMessage("O CEP informado é inválido.");
        }
        
    }
}