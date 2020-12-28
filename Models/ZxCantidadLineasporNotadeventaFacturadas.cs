using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxCantidadLineasporNotadeventaFacturadas
    {
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("Cantidad Lineas")]
        public int? CantidadLineas { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column("Fecha_factura", TypeName = "datetime")]
        public DateTime? FechaFactura { get; set; }
    }
}
