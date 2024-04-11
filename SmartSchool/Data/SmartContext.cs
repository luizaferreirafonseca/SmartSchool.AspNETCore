using Microsoft.EntityFrameworkCore;
using SmartSchool.Models;

namespace SmartSchool.Data
{
    public class SmartContext : DbContext

    {

        public SmartContext(DbContextOptions<SmartContext> options) : base(options) { }
        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Professor> Professor { get; set;}

        public DbSet<Disciplina> Disciplina { get; set;}

        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set;}

       protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlunoDisciplina>()
                .HasKey(AD => new { AD.AlunoId, AD.DisciplinaId });
        }


    }
}
