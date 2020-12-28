using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class FletesZonas
    {
        [Column(TypeName = "datetime")]
        public DateTime? FechaT { get; set; }
        [StringLength(10)]
        public string Factura { get; set; }
        public int? Flete { get; set; }
        [Column("Rut_Cliente")]
        [StringLength(10)]
        public string RutCliente { get; set; }
        [StringLength(4)]
        public string Zona { get; set; }
        [Column("VENDEDOR")]
        public int? Vendedor { get; set; }
    }
}
