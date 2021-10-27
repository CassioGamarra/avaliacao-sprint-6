using System;
namespace SisClientes.Models
{
    public class Endereco
    {
       public Guid Id { get; set; }
       public string Cep { get; set; }
       public string Numero { get; set; }
       public string Complemento { get; set; }
       public string Logradouro { get; set; }
       public string Bairro { get; set; }
       public char IndPrincipal { get; set; }
       public Guid CidadeId { get; set; }
       public Guid ClienteId { get; set; }
       public Cidade Cidade { get; set; }
       public Cliente Cliente { get; set; }

    }
}