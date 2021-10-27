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
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; } 
        public Guid CidadeId { get; set; }

        public IList<Endereco> Enderecos { get; set; }
    }
}