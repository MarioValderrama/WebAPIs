using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("LGCUBSEG")]
    public partial class Lgcubseg
    {
        [Key]
        [StringLength(10)]
        public string Documento { get; set; }
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        public int? Cubetas { get; set; }
        public int? Devueltas { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaDev { get; set; }
        [StringLength(60)]
        public string Cliente { get; set; }
    }
}
