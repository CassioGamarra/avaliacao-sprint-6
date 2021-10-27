using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SisClientes.Models;
using System;

namespace SisClientes.Configuration
{
    public class CidadeConfiguration : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("Cidades");
            builder.Property<Guid>("Id").IsRequired();
            builder.Property(cidade => cidade.Nome).IsRequired();
            builder.Property(cidade => cidade.Estado).IsRequired();
        }
    }
}