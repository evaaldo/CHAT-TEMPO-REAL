using GerenciamentoProdutos.Model;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoProdutos.Context
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
        public object Produto { get; internal set; }
    }
}