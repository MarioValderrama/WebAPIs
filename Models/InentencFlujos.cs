using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class InentencFlujos
    {
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("RUT")]
        [StringLength(10)]
        public string Rut { get; set; }
        [Column("PROVEEDOR")]
        [StringLength(40)]
        public string Proveedor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaVenc { get; set; }
        public double? Valor { get; set; }
        public bool? Pagado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaDoc { get; set; }
        public int? DiasPago { get; set; }
        [StringLength(22)]
        public string Expr1 { get; set; }
    }
}
