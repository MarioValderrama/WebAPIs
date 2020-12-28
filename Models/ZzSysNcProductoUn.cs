using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZzSysNcProductoUn
    {
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("UNNc")]
        public double? Unnc { get; set; }
    }
}
