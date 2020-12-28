using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("INDETAJU")]
    public partial class Indetaju
    {
        [Required]
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("FECHA", TypeName = "datetime2(0)")]
        public DateTime? Fecha { get; set; }
        [Column("CODBOD")]
        [StringLength(3)]
        public string Codbod { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("CODIGOB")]
        [StringLength(13)]
        public string Codigob { get; set; }
        public double? StockC { get; set; }
        public double? StockF { get; set; }
        public double? Diferencia { get; set; }
        [StringLength(4)]
        public string CodUni { get; set; }
        [Column("LOTE")]
        [StringLength(15)]
        public string Lote { get; set; }
        [Column("FECHA_VEN", TypeName = "datetime2(0)")]
        public DateTime? FechaVen { get; set; }
        [Column("POTENCIA")]
        public double? Potencia { get; set; }
        [Column("UBICA")]
        [StringLength(14)]
        public string Ubica { get; set; }
        [StringLength(8)]
        public string Usuario { get; set; }
        [StringLength(100)]
        public string Observaciones { get; set; }
        public int? Local { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
