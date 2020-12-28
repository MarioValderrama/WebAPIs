using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class VevenencVenta2017
    {
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("Rut_Cliente")]
        [StringLength(10)]
        public string RutCliente { get; set; }
        [Column("DV")]
        [StringLength(1)]
        public string Dv { get; set; }
        [StringLength(80)]
        public string Cliente { get; set; }
        [Column("Valor_Neto")]
        public double? ValorNeto { get; set; }
        [StringLength(80)]
        public string Vendedor { get; set; }
        [Column("Tipo_Doc")]
        [StringLength(2)]
        public string TipoDoc { get; set; }
        [StringLength(4)]
        public string Zona { get; set; }
        [Column("CIUDAD")]
        [StringLength(4)]
        public string Ciudad { get; set; }
        public double? Total { get; set; }
    }
}
