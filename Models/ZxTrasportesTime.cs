using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxTrasportesTime
    {
        [Column("Fecha_Factura", TypeName = "datetime")]
        public DateTime? FechaFactura { get; set; }
        [StringLength(4)]
        public string Trans { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaT { get; set; }
        [StringLength(20)]
        public string Boleto { get; set; }
        [StringLength(35)]
        public string DesTrans { get; set; }
        [StringLength(10)]
        public string Preparacion { get; set; }
        [StringLength(10)]
        public string Factura { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
    }
}
