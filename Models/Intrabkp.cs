using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("INTRABKP")]
    public partial class Intrabkp
    {
        [Column("FOLIO")]
        public int? Folio { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("TIPO")]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Column("LOCAL")]
        public int? Local { get; set; }
        [Column("BODEGAO")]
        [StringLength(4)]
        public string Bodegao { get; set; }
        [Column("BODEGAD")]
        [StringLength(4)]
        public string Bodegad { get; set; }
        [Column("CODIGOB")]
        [StringLength(14)]
        public string Codigob { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("QREAL")]
        public double? Qreal { get; set; }
        [Column("CODUNI")]
        [StringLength(4)]
        public string Coduni { get; set; }
        [Column("CODUNIR")]
        [StringLength(4)]
        public string Codunir { get; set; }
        [Column("FACTORV")]
        public double? Factorv { get; set; }
        [Column("LOTE")]
        [StringLength(15)]
        public string Lote { get; set; }
        [Column("UBICACION")]
        [StringLength(14)]
        public string Ubicacion { get; set; }
        [Column("VENCE", TypeName = "datetime2(0)")]
        public DateTime? Vence { get; set; }
        [Column("UBICADEST")]
        [StringLength(14)]
        public string Ubicadest { get; set; }
        [Column("MOTIVO")]
        [StringLength(4)]
        public string Motivo { get; set; }
        [Column("OBSERVACION")]
        [StringLength(50)]
        public string Observacion { get; set; }
        [Column("Costo_Prom")]
        public double? CostoProm { get; set; }
        [StringLength(8)]
        public string Usuario { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
