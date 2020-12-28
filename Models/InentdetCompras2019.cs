using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class InentdetCompras2019
    {
        [StringLength(10)]
        public string Código { get; set; }
        [Required]
        [StringLength(10)]
        public string Ingreso { get; set; }
        [Column("Fecha_Ing", TypeName = "datetime2(0)")]
        public DateTime? FechaIng { get; set; }
        public double? Cantidad { get; set; }
        public double? Costo { get; set; }
        [Column("PROVEEDOR")]
        [StringLength(80)]
        public string Proveedor { get; set; }
        [StringLength(10)]
        public string RutPrv { get; set; }
        [StringLength(1)]
        public string TipoRut { get; set; }
    }
}
