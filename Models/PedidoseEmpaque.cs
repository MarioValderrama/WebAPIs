using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class PedidoseEmpaque
    {
        public double? Total { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
        [StringLength(2)]
        public string Area { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("Des_Per")]
        [StringLength(35)]
        public string DesPer { get; set; }
        [Column("TFolio")]
        public int? Tfolio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Expr1 { get; set; }
        [Column("Fecha_T", TypeName = "datetime")]
        public DateTime? FechaT { get; set; }
    }
}
