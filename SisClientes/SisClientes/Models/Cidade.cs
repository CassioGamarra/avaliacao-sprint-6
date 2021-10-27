using System;
using System.Collections.Generic;

namespace SisClientes.Models
{
    public class Cidade
    {
        public Guid Id { get; set; }  
        public string Nome { get; set; } 
        public string Estado { get; set; } 
        public IList<Endereco> Enderecos { get; set; }
    }
}