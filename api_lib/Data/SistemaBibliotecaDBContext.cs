using api_lib.Models;
using Microsoft.EntityFrameworkCore;

namespace api_lib.Data
{
    public class SistemaBibliotecaDBContext : DbContext
    {
        public SistemaBibliotecaDBContext(DbContextOptions<SistemaBibliotecaDBContext> options)
        : base(options)
        {

        }

        public DbSet<LivroModel> Livros { get; set; }

        public DbSet<LocaçãoModel> Locações { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
