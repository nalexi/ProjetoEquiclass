using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Equiclasses")]
    public class Equiclass : Base
    {
        [Column("cnpj")]
        public string Cnpj;

        [Column("nome")]
        public string Nome;

        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
