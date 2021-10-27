using System;
using System.Collections.Generic;

namespace SisClientes.DTOs
{
    public class ClienteDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; } 
        public IList<EnderecoDTO> Enderecos { get; set; }
    }
}