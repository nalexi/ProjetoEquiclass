using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("palestrantes")]
    public class Palestrante : Base
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("curriculo")]
        public string Curriculo { get; set; }

        public virtual ICollection<CursoPalestrante> CursosPalestrantes { get; set; }
    }
}
