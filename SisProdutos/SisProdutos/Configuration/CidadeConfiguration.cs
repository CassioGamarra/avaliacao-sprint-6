using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SisProdutos.Models;
using System;

namespace SisProdutos.Configuration
{
    public class CidadeConfiguration : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("Cidades");
            builder.Property<Guid>("ID").IsRequired();
            builder.Property(cidade => cidade.Nome).IsRequired();
            builder.Property(cidade => cidade.Estado).IsRequired();
        }
    }
}