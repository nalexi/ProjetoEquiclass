using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("cursos")]
    public class Curso : Base
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("investimento")]
        public decimal Investimento { get; set; }

        [Column("id_opcao_hospedagem"), ForeignKey("OpcaoHospedagem")]
        public int OpcaoHospedagemId { get; set; }
        public virtual OpcaoHospedagem OpcaoHospedagem { get; set; }

        [Column("id_parceiro"), ForeignKey("Parceiro")]
        public int ParceiroId { get; set; }
        public virtual Parceiro Parceiro { get; set; }

        [Column("id_equiclass"), ForeignKey("Equiclass")]
        public int EquiclassId { get; set; }
        public virtual Equiclass Equiclass { get; set; }

        [Column("alunos_cursos")]
        public virtual ICollection<AlunoCurso> AlunosCursos { get; set; }

        [Column("curso_palestrante")]
        public virtual ICollection<CursoPalestrante> CursosPalestrantes { get; set; }

        [Column("curso_parceiro")]
        public virtual ICollection<ParceiroCurso> ParceirosCursos { get; set; }
    }
}
