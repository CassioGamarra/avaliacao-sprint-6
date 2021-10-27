using System;

namespace SisProdutos.DTOs
{
    public class ProdutoCidadeDTO
    {
        public Guid CidadeId { get; set; }
        public Guid ProdutoId { get; set; }
        public CidadeDTO Cidade { get; set; }
        public ProdutoDTO Produto { get; set; }
    }
}