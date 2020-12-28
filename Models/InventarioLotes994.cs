using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class InventarioLotes994
    {
        [Column("CODBOD")]
        [StringLength(3)]
        public string Codbod { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("NLOTE")]
        [StringLength(15)]
        public string Nlote { get; set; }
        public double? Expr1 { get; set; }
        [Column("FECHA_V", TypeName = "datetime")]
        public DateTime? FechaV { get; set; }
    }
}
