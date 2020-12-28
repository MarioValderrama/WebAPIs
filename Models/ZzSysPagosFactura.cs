using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZzSysPagosFactura
    {
        [StringLength(10)]
        public string Factura { get; set; }
        [Column("Monto_Ref")]
        public double? MontoRef { get; set; }
        [Column("Big_numero")]
        public long? BigNumero { get; set; }
    }
}
