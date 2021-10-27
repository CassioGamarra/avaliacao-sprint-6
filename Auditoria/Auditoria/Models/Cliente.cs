using System;
using System.Collections.Generic;

namespace SisClientes.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; } 
        public IList<Endereco> Enderecos { get; set; }
    }
}