using FluentValidation;
using SisClientes.DTOs;
namespace SisClientes.Validators
{
    public class ClienteValidator : AbstractValidator<ClienteDTO>
    {
        public ClienteValidator()
        {
            RuleFor(cliente => cliente.Nome).NotEmpty().WithMessage("Por favor, preencha o nome do cliente.");
            RuleFor(cliente => cliente.CPF).NotEmpty().WithMessage("Por favor, preencha o CPF."); 
            RuleFor(cliente => cliente.DataNascimento).NotEmpty().WithMessage("Por favor, preencha a data de nascimento.");  
        }
    }
}