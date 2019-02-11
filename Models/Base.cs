using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Base
    {
        [Key]
        public int Id { get; set; }

        [Column("registro_ativo"), Required]
        public bool RegistroAtivo { get; set; }
    }
}
