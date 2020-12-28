using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("INDPRDET")]
    public partial class Indprdet
    {
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("CODIGOB")]
        [StringLength(14)]
        public string Codigob { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("CANTIDAD")]
        public int? Cantidad { get; set; }
        [Column("Cant_aDev")]
        public int? CantADev { get; set; }
        [Column("CODUNI")]
        [StringLength(4)]
        public string Coduni { get; set; }
        [Column("LOTE")]
        [StringLength(15)]
        public string Lote { get; set; }
        [Column("VENCE", TypeName = "datetime")]
        public DateTime? Vence { get; set; }
        [Column("UBICACION")]
        [StringLength(14)]
        public string Ubicacion { get; set; }
        [Column("MOTIVO")]
        [StringLength(1)]
        public string Motivo { get; set; }
        [Column("OBSERVACION")]
        [StringLength(50)]
        public string Observacion { get; set; }
        public double? ValorL { get; set; }
        public int? Canjes { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
