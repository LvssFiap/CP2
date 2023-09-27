using CP2.Models;
using Microsoft.EntityFrameworkCore;

namespace CP2.Persistence
{
    public class OracleDBContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        public OracleDBContext(DbContextOptions<OracleDBContext> options) : base(options)
        {

        }
    }
}
