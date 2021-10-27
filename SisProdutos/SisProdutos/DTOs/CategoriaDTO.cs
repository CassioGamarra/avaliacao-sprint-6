using System;
using System.Collections.Generic;

namespace SisProdutos.DTOs
{
    public class CategoriaDTO
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public IList<ProdutoDTO> Produtos { get; set; }
    }
}