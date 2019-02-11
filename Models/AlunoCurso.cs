using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("alunos_curso")]
    public class AlunoCurso : Base
    {
        [Column("id_aluno")]
        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }

        [Column("id_curso")]
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
