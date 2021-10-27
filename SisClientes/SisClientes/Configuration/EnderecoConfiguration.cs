using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SisClientes.Models;
using System;

namespace SisClientes.Configuration
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Enderecos");
            builder.Property<Guid>("Id").IsRequired();
            builder.Property(endereco => endereco.CidadeId).IsRequired().HasColumnName("CidadeId");
            builder.Property(endereco => endereco.ClienteId).IsRequired().HasColumnName("ClienteId");
            builder.Property(endereco => endereco.Cep).IsRequired();
            builder.Property(endereco => endereco.Numero).IsRequired();
            builder.Property(endereco => endereco.Complemento);
            builder.Property(endereco => endereco.Bairro).IsRequired();
            builder.Property(endereco => endereco.Logradouro).IsRequired();
            builder.Property(endereco => endereco.IndPrincipal).IsRequired();

            builder.HasOne(endereco => endereco.Cidade)
                .WithMany(cidade => cidade.Enderecos)
                .HasForeignKey("CidadeId");
            builder.HasOne(endereco => endereco.Cliente)
                .WithMany(cliente => cliente.Enderecos)
                .HasForeignKey("ClienteId");
        }
    }
}