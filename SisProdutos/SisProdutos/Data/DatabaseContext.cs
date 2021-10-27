using Microsoft.EntityFrameworkCore;
using SisProdutos.Configuration;
using SisProdutos.Models; 

namespace SisProdutos.Data
{
    public class DatabaseContext : DbContext
    {   
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; } 
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<ProdutoCidade> ProdutosCidades { get; set; }
        
        public DatabaseContext(DbContextOptions<DatabaseContext> opt) : base (opt)
        {

        }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());  
            modelBuilder.ApplyConfiguration(new CidadeConfiguration()); 
            modelBuilder.ApplyConfiguration(new ProdutoCidadeConfiguration());
        }
    }
}