using LocadoraJogos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraJogos.DAO
{
    public class LojaContext : DbContext
    {
        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaJogosDB;Trusted_Connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<ItemPedido>()
                .HasKey(ip => new { ip.PedidoId, ip.ProdutoId });
        }
    }
}