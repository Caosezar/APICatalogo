using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace APICatalogo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public System.Data.Entity.DbSet<Categoria>? Categorias { get; set; }
        public System.Data.Entity.DbSet<Produto>? Produtos { get; set; }
    }
}
