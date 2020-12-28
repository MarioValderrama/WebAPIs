using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZzSysNcComprasAnual
    {
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("QREAL")]
        public float? Qreal { get; set; }
        [Column("FECHA", TypeName = "datetime2(0)")]
        public DateTime Fecha { get; set; }
        [Column("VENDEDOR")]
        public int? Vendedor { get; set; }
        [Column("Rut_Cliente")]
        [StringLength(10)]
        public string RutCliente { get; set; }
    }
}
