using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class InentdetComprasCm
    {
        [StringLength(10)]
        public string Ingreso { get; set; }
        [Column("Fecha_Ing", TypeName = "datetime")]
        public DateTime? FechaIng { get; set; }
        [StringLength(10)]
        public string Código { get; set; }
        public double? Cantidad { get; set; }
        public double? Costo { get; set; }
        [Column("PROVEEDOR")]
        [StringLength(40)]
        public string Proveedor { get; set; }
        [StringLength(1)]
        public string TipoRut { get; set; }
    }
}
