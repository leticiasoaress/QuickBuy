using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades.Pedidos;
using QuickBuy.Dominio.Entidades.Produtos;
using QuickBuy.Dominio.Entidades.Usuarios;
using QuickBuy.Dominio.ValueObjects;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public QuickBuyContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento() 
                { 
                    Id = 1, 
                    Nome = "Boleto", 
                    Descricao = "Forma de Pagamento Boleto" 
                },
                new FormaPagamento() 
                { 
                    Id = 2, 
                    Nome = "Cartão de Crédito", 
                    Descricao = "Forma de Pagamento Cartão de Crédito" 
                },
                new FormaPagamento() 
                {
                    Id = 3, 
                    Nome = "Pix",
                    Descricao = "Forma de Pagamento Pix" 
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}