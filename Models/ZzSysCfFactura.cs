using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZzSysCfFactura
    {
        [StringLength(10)]
        public string Factura { get; set; }
        [Column("Monto_Ref")]
        public double? MontoRef { get; set; }
    }
}
