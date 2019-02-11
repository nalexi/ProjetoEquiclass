using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("cursos_parceiros")]
    public class ParceiroCurso : Base
    {
        [Column("id_parceiro")]
        public int ParcdeiroId { get; set; }
        public virtual Parceiro Parceiro { get; set; }

        [Column("id_curso")]
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }
    }

}
