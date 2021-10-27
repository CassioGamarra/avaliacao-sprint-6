using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SisProdutos.Models;
using System;

namespace SisProdutos.Configuration
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Categorias");
            builder.Property<Guid>("ID").IsRequired();
            builder.Property(produto => produto.CategoriaId).IsRequired().HasColumnName("CategoriaId");
            builder.Property(produto => produto.Nome).IsRequired();
            builder.Property(produto => produto.Descricao).IsRequired();
            builder.Property(produto => produto.Preco).IsRequired();
            builder.Property(produto => produto.PalavrasChaves).IsRequired();
            
            builder.HasOne(produto => produto.Categoria)
                .WithMany(categoria => categoria.Produtos)
                .HasForeignKey("CategoriaId");
        }
    }
}