using System;
using System.Collections.Generic;

namespace SisClientes.DTOs
{
    public class CidadeDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
        public IList<EnderecoDTO> Enderecos { get; set; }
    }
}