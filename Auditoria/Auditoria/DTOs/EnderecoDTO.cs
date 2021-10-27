using System;
using System.Collections.Generic;

namespace SisClientes.DTOs
{
    public class EnderecoDTO
    {
        public Guid Id { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public bool IndPrincipal { get; set; }
        public Guid CidadeId { get; set; }
        public Guid ClienteId { get; set; }
        public CidadeDTO Cidade { get; set; }
        public ClienteDTO Cliente { get; set; }
    }
}