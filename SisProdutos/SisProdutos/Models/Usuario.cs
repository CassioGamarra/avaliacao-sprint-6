using System;

namespace SisProdutos.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Cadastrado { get; set; }
    }
}