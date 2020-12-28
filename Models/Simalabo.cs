using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIMALABO")]
    public partial class Simalabo
    {
        [Key]
        [Column("CODIGO_LAB")]
        [StringLength(7)]
        public string CodigoLab { get; set; }
        [Column("DESCRI_LAB")]
        [StringLength(35)]
        public string DescriLab { get; set; }
        [Column("TIPO")]
        [StringLength(1)]
        public string Tipo { get; set; }
        public int? Orden { get; set; }
    }
}
