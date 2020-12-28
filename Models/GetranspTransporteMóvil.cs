using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class GetranspTransporteMóvil
    {
        [StringLength(80)]
        public string Cliente { get; set; }
        public int? Bultos { get; set; }
        [Column("Fecha_al_TRansporte", TypeName = "datetime")]
        public DateTime? FechaAlTransporte { get; set; }
        [Column("RUT")]
        [StringLength(10)]
        public string Rut { get; set; }
        public int? Dirección { get; set; }
        [StringLength(35)]
        public string Comuna { get; set; }
        [StringLength(35)]
        public string Expr7 { get; set; }
        public double? Expr8 { get; set; }
        public int? Expr9 { get; set; }
        [StringLength(50)]
        public string Expr10 { get; set; }
        [StringLength(50)]
        public string Expr11 { get; set; }
        [StringLength(20)]
        public string Expr12 { get; set; }
        [StringLength(255)]
        public string Expr13 { get; set; }
        [StringLength(10)]
        public string Expr14 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Expr15 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Expr16 { get; set; }
        [StringLength(1)]
        public string Expr17 { get; set; }
        [StringLength(10)]
        public string Expr18 { get; set; }
    }
}
