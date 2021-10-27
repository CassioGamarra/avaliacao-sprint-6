using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SisClientes.Models;
using System;

namespace SisClientes.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
             
            builder.Property<Guid>("Id").IsRequired();
            builder.Property(cliente => cliente.Nome).IsRequired();
            builder.Property(cliente => cliente.CPF).IsRequired();
            builder.Property(cliente => cliente.DataNascimento).IsRequired(); 
        }
    }
}