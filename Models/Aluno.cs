using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("alunos")]
    public class Aluno : Base
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("rg")]
        public string Rg { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("cidade")]
        public string Cidade { get; set; }

        [Column("bairro")]
        public string Bairro { get; set; }

        public virtual ICollection<AlunoCurso> AlunosCursos { get; set; }
    }
}
