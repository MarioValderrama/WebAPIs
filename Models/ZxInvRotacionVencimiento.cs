using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxInvRotacionVencimiento
    {
        [Column("CODBOD")]
        [StringLength(3)]
        public string Codbod { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("NLOTE")]
        [StringLength(15)]
        public string Nlote { get; set; }
        [StringLength(4000)]
        public string FechaVencimiento { get; set; }
        public int? MesesdeVenta { get; set; }
        public int? Mesesparaliquidacio { get; set; }
        public int? MesesparaCanje { get; set; }
        [Column("DESCRI_BOD")]
        [StringLength(35)]
        public string DescriBod { get; set; }
        [Column("DESCRI_COM")]
        [StringLength(60)]
        public string DescriCom { get; set; }
        [Column("PRECIO_VEN")]
        public double? PrecioVen { get; set; }
        [Column("COSTO_PROM")]
        public double? CostoProm { get; set; }
        [StringLength(7)]
        public string Labo { get; set; }
        [Column("STOCK")]
        public double? Stock { get; set; }
        [Column("RESERVA")]
        public double? Reserva { get; set; }
        public double? Disponible { get; set; }
        public double? CostoTotal { get; set; }
        [Column("PrecioVTotal")]
        public double? PrecioVtotal { get; set; }
        [Column("DESCRI_LAB")]
        [StringLength(35)]
        public string DescriLab { get; set; }
    }
}
