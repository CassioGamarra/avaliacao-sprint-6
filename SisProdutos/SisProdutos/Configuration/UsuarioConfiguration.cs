using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SisProdutos.Models;
using System;

namespace SisProdutos.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        { 
            builder.ToTable("Categorias");
            builder.Property<Guid>("ID").IsRequired();
            builder.Property(usuario => usuario.Email).IsRequired();
            builder.Property(usuario => usuario.Senha).IsRequired();
            builder.Property(usuario => usuario.Cadastrado).HasDefaultValue(false);
        }
    }
}