using System;

namespace SisProdutos.DTOs
{
    public class UsuarioDTO
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Cadastrado { get; set; }
    }
}