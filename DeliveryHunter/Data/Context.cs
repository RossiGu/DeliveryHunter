using DeliveryHunter.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryHunter.Data
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VI6J4HL\\SQLEXPRESS;Database=DeliveryHunter;Trusted_Connection=True; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasKey(m => m.CategoriaId);
            modelBuilder.Entity<Cliente>().HasKey(m => m.IdCliente);
            modelBuilder.Entity<Estabelecimento>().HasKey(m => m.Id);
            modelBuilder.Entity<Pedido>().HasKey(m => m.Id);
            modelBuilder.Entity<Produto>().HasKey(m => m.ProdutoId);
        }

        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Estabelecimento> estabelecimentos { get; set; }
        public DbSet<Pedido> pedidos { get; set; }
        public DbSet<Produto> produtos { get; set; }
    }
}
