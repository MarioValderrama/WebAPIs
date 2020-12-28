using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxDatosDespacho
    {
        [StringLength(10)]
        public string Factura { get; set; }
        [Column("Fecha_factura", TypeName = "datetime")]
        public DateTime? FechaFactura { get; set; }
        [Column("NETO")]
        public double? Neto { get; set; }
        [Column("IVA")]
        public double? Iva { get; set; }
        [Column("TOTAL")]
        public double? Total { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
        [StringLength(10)]
        public string NumGuia { get; set; }
        [StringLength(10)]
        public string NumPreparacion { get; set; }
        [StringLength(20)]
        public string Boleto { get; set; }
        [StringLength(4)]
        public string Trans { get; set; }
        [StringLength(35)]
        public string DesTrans { get; set; }
        [StringLength(1)]
        public string TipoTrans { get; set; }
        [StringLength(2)]
        public string Tipo { get; set; }
        [Column("Fecha_Despacho", TypeName = "datetime")]
        public DateTime? FechaDespacho { get; set; }
    }
}
