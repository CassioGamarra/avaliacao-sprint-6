using System;
using System.Collections.Generic;

namespace SisProdutos.Models
{
    public class Categoria
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public IList<Produto> Produtos { get; set; }
    }
}