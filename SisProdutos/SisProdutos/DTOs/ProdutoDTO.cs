using System;

namespace SisProdutos.DTOs
{
    public class ProdutoDTO
    {
        public Guid Id { get; set; }  
        public string Nome { get; set; } 
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string PalavrasChaves { get; set; }
        public Guid CategoriaId { get; set; }
        public CategoriaDTO Categoria { get; set; }
    }
}