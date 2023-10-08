using Microsoft.EntityFrameworkCore;

namespace api_cpa_ifmg.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CampusCurso>()
                .HasKey(c => new { c.CampusId, c.CursoId });
            builder.Entity<CampusCurso>()
                .HasOne(c => c.Campus).WithMany(c => c.Cursos)
                .HasForeignKey(c => c.CampusId);
                
            builder.Entity<CampusCurso>()
                .HasOne(c => c.Curso).WithMany(c => c.Campuses)
                .HasForeignKey(c => c.CursoId);

            builder.Entity<Eixo>().HasOne(s => s.Ciclo)
                .WithMany().HasForeignKey(s => s.CicloId)
                .OnDelete(DeleteBehavior.ClientNoAction);
            builder.Entity<Eixo>().HasOne(s => s.Questionario)
                .WithMany().HasForeignKey(s => s.QuestionarioId)
                .OnDelete(DeleteBehavior.ClientNoAction);

        }
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<Ciclo> Ciclos { get; set; }
        public DbSet<Cronograma> Cronogramas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Dimensao> Dimensoes { get; set; }
        public DbSet<Eixo> Eixos { get; set; }
        public DbSet<Indicador> Indicadores { get; set; }
        public DbSet<Melhoria> Melhorias { get; set; }
        public DbSet<Membro> Membros { get; set; }
        public DbSet<Meta> Metas { get; set; }
        public DbSet<Proposta> Propostas { get; set; }
        public DbSet<Questionario> Questionarios { get; set; }
        public DbSet<CampusCurso> CampusCursos { get; set; }


    }
}
