using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SisProdutos.Models;
using System;

namespace SisProdutos.Configuration
{
    public class ProdutoCidadeConfiguration : IEntityTypeConfiguration<ProdutoCidade>
    {
        public void Configure(EntityTypeBuilder<ProdutoCidade> builder)
        {
            builder.ToTable("Produtos_Cidades");
            builder.Property(produtoCidade => produtoCidade.CidadeId).IsRequired().HasColumnName("CidadeId");
            builder.Property(produtoCidade => produtoCidade.ProdutoId).IsRequired().HasColumnName("ProdutoId");
        }
    }
}