using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIPARAMG")]
    public partial class Siparamg
    {
        [Key]
        [Column("CLAVE")]
        [StringLength(5)]
        public string Clave { get; set; }
        [Column("TIPO")]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Column("VALOR")]
        [StringLength(40)]
        public string Valor { get; set; }
    }
}
