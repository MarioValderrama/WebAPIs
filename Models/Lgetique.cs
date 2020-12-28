using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("LGETIQUE")]
    public partial class Lgetique
    {
        [Column("NGuía")]
        [StringLength(10)]
        public string Nguía { get; set; }
        [StringLength(5)]
        public string Desde { get; set; }
        [StringLength(5)]
        public string Hasta { get; set; }
        [StringLength(100)]
        public string Cliente { get; set; }
        [StringLength(50)]
        public string Canal { get; set; }
        [StringLength(10)]
        public string Zona { get; set; }
        [StringLength(10)]
        public string Operario { get; set; }
        [StringLength(10)]
        public string Bodega { get; set; }
        [Column("NV")]
        [StringLength(10)]
        public string Nv { get; set; }
        [StringLength(1)]
        public string Tipo { get; set; }
    }
}
