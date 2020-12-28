using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("CORESPAG")]
    public partial class Corespag
    {
        [StringLength(12)]
        public string Rut { get; set; }
        public int? Vendedor { get; set; }
        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(1)]
        public string Est { get; set; }
        [Column("OC")]
        [StringLength(20)]
        public string Oc { get; set; }
        [StringLength(10)]
        public string Factura { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        public int? Total { get; set; }
        [Column("NC")]
        public int? Nc { get; set; }
        [Column("ND")]
        public int? Nd { get; set; }
        public int? Pagos { get; set; }
        public int? Saldo { get; set; }
        [Column("0_30")]
        public int? _030 { get; set; }
        [Column("31_60")]
        public int? _3160 { get; set; }
        [Column("61_90")]
        public int? _6190 { get; set; }
        [Column("91_120")]
        public int? _91120 { get; set; }
        [Column("121_365")]
        public int? _121365 { get; set; }
        [Column("365m")]
        public int? _365m { get; set; }
        [Column("RS")]
        [StringLength(100)]
        public string Rs { get; set; }
        [StringLength(4)]
        public string Región { get; set; }
        [StringLength(100)]
        public string NomVend { get; set; }
    }
}
