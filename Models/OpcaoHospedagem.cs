using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("opcoes_hospedagem")]
    public class OpcaoHospedagem : Base
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("cidade")]
        public string Cidade { get; set; }

        [Column("bairro")]
        public string Bairro { get; set; }

        [Column("distancia_local")]
        public float DistanciaLocal { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
