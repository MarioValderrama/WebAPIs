using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class SgifDatosArtículos
    {
        [StringLength(10)]
        public string Código { get; set; }
        [StringLength(60)]
        public string Resumida { get; set; }
        [StringLength(1)]
        public string Est { get; set; }
        [Column("Precio Venta")]
        public double? PrecioVenta { get; set; }
        [Column("Costo Promedio")]
        public double? CostoPromedio { get; set; }
        public int? Cons1 { get; set; }
        public int? Cons2 { get; set; }
        public int? Cons3 { get; set; }
        public int? Cons4 { get; set; }
        public int? Cons5 { get; set; }
        public int? Cons6 { get; set; }
        [Column("St_Vend")]
        public double? StVend { get; set; }
        [Column("Rot_Prom")]
        public int? RotProm { get; set; }
        [Required]
        [Column("Es_Drog")]
        [StringLength(2)]
        public string EsDrog { get; set; }
    }
}
