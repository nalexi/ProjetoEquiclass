using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("parceiros")]
    public class Parceiro : Base
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("cidade")]
        public string Cidade { get; set; }

        [Column("bairro")]
        public string Bairro { get; set; }

        [Column("cnpj")]
        public string Cnpj { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("cursos")]
        public virtual ICollection<Curso> Cursos { get; set; }

        public virtual ICollection<ParceiroCurso> ParceirosCursos { get; set; }
    }
}
