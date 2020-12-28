using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class SgifInventarioVendible
    {
        [Column("codmp")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("stock_final")]
        public double? StockFinal { get; set; }
        [Column("Precio_Venta")]
        public double? PrecioVenta { get; set; }
        public double? Costo { get; set; }
        [Required]
        [Column("Es_Drog")]
        [StringLength(2)]
        public string EsDrog { get; set; }
        [Column("Rot_Prom")]
        public int? RotProm { get; set; }
    }
}
