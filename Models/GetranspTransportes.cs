using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class GetranspTransportes
    {
        [Column("No_Factura")]
        public int? NoFactura { get; set; }
        [Column("Fecha_Transporte", TypeName = "datetime")]
        public DateTime? FechaTransporte { get; set; }
        [StringLength(10)]
        public string Guía { get; set; }
        [StringLength(4)]
        public string Trans { get; set; }
        [StringLength(20)]
        public string Boleto { get; set; }
        public float? Peso { get; set; }
        public float? Volumen { get; set; }
        [Column("Peso_Vol")]
        public double? PesoVol { get; set; }
        public int? Flete { get; set; }
        public int? Bultos { get; set; }
        [StringLength(4)]
        public string Transporte { get; set; }
        [StringLength(255)]
        public string Obs { get; set; }
    }
}
