using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Database
{
    public class EquiclassContext : DbContext
    {
        public EquiclassContext() : base("EquiclassConexao")
        {
            System.Data.Entity.Database.SetInitializer<EquiclassContext>(new EquiclassInitializer());
        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<AlunoCurso> AlunosCursos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<CursoPalestrante> CursosPalestrantes { get; set; }
        public DbSet<Equiclass> Equiclasses { get; set; }
        public DbSet<OpcaoHospedagem> OpcoesHospedagem { get; set; }
        public DbSet<Palestrante> Palestrantes { get; set; }
        public DbSet<Parceiro> Parceiros { get; set; }
        public DbSet<ParceiroCurso> ParceirosCursos { get; set; }
    }
}
