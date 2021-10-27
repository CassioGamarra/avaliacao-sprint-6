using Microsoft.EntityFrameworkCore;
using SisClientes.Configuration;
using SisClientes.Models; 

namespace SisClientes.Data
{
    public class DatabaseContext : DbContext
    { 
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> opt) : base (opt)
        {

        }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new CidadeConfiguration()); 
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration()); 
        }
    }
}