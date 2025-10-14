using Microsoft.EntityFrameworkCore;
using ApiEPharmacy.Models;

namespace ApiEPharmacy.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<UsuarioSistema> UsuarioSistema { get; set; }
        public DbSet<BairroZona> BairroZona { get; set; }
        public DbSet<ClasseTerapeutica> ClasseTerapeutica { get; set; }
        public DbSet<Clinica> Clinica { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relacionamento
            modelBuilder.Entity<Medico>()
                .HasOne(m => m.Especialidade);
                //.WithMany(e => e.Medico)
                //.HasForeignKey(m => m.EspecialidadeId);
        }
    }
}