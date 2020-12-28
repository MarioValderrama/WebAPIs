using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZzSysInventarioVendible
    {
        [Column("codmp")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("stock_final")]
        public double? StockFinal { get; set; }
    }
}
