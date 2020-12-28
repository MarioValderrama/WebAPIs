using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZzSysNotasDeVentaRepasoProducto
    {
        [Column("pedidos1")]
        public double? Pedidos1 { get; set; }
        [StringLength(10)]
        public string CodMp { get; set; }
    }
}
