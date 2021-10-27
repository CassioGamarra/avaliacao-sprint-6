using System;

namespace SisProdutos.Models
{
    public class ProdutoCidade
    {
        public Guid CidadeId { get; set; }
        public Guid ProdutoId { get; set; }
        public Cidade Cidade { get; set; }
        public Produto Produto { get; set; }
    }
}