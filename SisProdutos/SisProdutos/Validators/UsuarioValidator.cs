using FluentValidation;
using SisProdutos.DTOs;

namespace SisProdutos.Validators
{
    public class UsuarioValidator : AbstractValidator<UsuarioDTO>
    {
        public UsuarioValidator()
        {
            RuleFor(usuario => usuario.Email).NotEmpty().WithMessage("Por favor, preencha o email.");
            RuleFor(usuario => usuario.Senha).NotEmpty().WithMessage("Por favor, preencha a senha.");
        }
    }
}