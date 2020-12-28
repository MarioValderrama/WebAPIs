using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class InventarioVendible
    {
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("stock_final")]
        public double? StockFinal { get; set; }
    }
}
