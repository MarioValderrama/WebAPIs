using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZzSysGuíaComprasAnual
    {
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("CANTIDAD")]
        public double? Cantidad { get; set; }
        [Column("FECHA", TypeName = "datetime2(0)")]
        public DateTime? Fecha { get; set; }
        public int? Vendedor { get; set; }
        [StringLength(10)]
        public string RutCli { get; set; }
        [StringLength(1)]
        public string EstVenta { get; set; }
    }
}
