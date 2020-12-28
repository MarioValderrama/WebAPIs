using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxVentaporPreparacion
    {
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("BODEGA")]
        [StringLength(4)]
        public string Bodega { get; set; }
        [Column("Cant_Solicitada")]
        public double? CantSolicitada { get; set; }
        [Column("Cant_Guia")]
        public double? CantGuia { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("Precio Unit")]
        public double? PrecioUnit { get; set; }
        [Column("Venta_Solicitada")]
        public double? VentaSolicitada { get; set; }
        [Column("Costo_tatal")]
        public double? CostoTatal { get; set; }
        [Column("Cant_Conf")]
        public double? CantConf { get; set; }
        [Column("Venta_Confirmada")]
        public double? VentaConfirmada { get; set; }
    }
}
