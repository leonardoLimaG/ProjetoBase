using Microsoft.EntityFrameworkCore;
using ProjetoBase.Models;

namespace ProjetoBase.Context
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<DespesaModel> Despesas { get; set; }
    }
}
