using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxCantidaddeitemenpreparacion
    {
        [StringLength(10)]
        public string NotaVenta { get; set; }
        [Column("Total Lineas")]
        public int? TotalLineas { get; set; }
        [Column("Total Unidades")]
        public double? TotalUnidades { get; set; }
        [Column("Canal Global")]
        [StringLength(35)]
        public string CanalGlobal { get; set; }
    }
}
