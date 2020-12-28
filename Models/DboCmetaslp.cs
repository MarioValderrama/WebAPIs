using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("dbo_CMETASLP")]
    public partial class DboCmetaslp
    {
        public short? Vendedor { get; set; }
        [Column("FIni", TypeName = "datetime")]
        public DateTime? Fini { get; set; }
        [Column("FFin", TypeName = "datetime")]
        public DateTime? Ffin { get; set; }
        [StringLength(10)]
        public string Código { get; set; }
        [Column("Tipo_Cód")]
        [StringLength(1)]
        public string TipoCód { get; set; }
        public double? Venta { get; set; }
        public double? Contribución { get; set; }
        public int? VentaP { get; set; }
        public int? Venta01 { get; set; }
        public int? Venta02 { get; set; }
        public int? Venta03 { get; set; }
        public int? Venta04 { get; set; }
        public int? Venta05 { get; set; }
        public int? Venta06 { get; set; }
    }
}
