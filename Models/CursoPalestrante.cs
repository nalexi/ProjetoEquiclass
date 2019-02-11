﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("cursos_palestrantes")]
    public class CursoPalestrante : Base
    {
        [Column("id_palestrante")]
        public int PalestranteId { get; set; }
        public virtual Palestrante Palestrante { get; set; }

        [Column("id_curso")]
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
