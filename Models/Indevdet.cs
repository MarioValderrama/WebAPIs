using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("INDEVDET")]
    public partial class Indevdet
    {
        [StringLength(10)]
        public string NumGuia { get; set; }
        public int? Local { get; set; }
        [Column("CODIGOB")]
        [StringLength(14)]
        public string Codigob { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("CANTIDAD")]
        public double? Cantidad { get; set; }
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
        [Column("VENCE", TypeName = "datetime")]
        public DateTime? Vence { get; set; }
        [Column("MOTIVO")]
        [StringLength(4)]
        public string Motivo { get; set; }
        [Column("OBSERVACION")]
        [StringLength(50)]
        public string Observacion { get; set; }
        [Column("Cant_aDev")]
        public double? CantADev { get; set; }
        public double? Costop { get; set; }
        public int? LinPed { get; set; }
        public double? PrecioP { get; set; }
        [StringLength(1)]
        public string EstGuia { get; set; }
        [Required]
        [Column("NC")]
        [StringLength(1)]
        public string Nc { get; set; }
        [StringLength(15)]
        public string LoteAnt { get; set; }
        public double? PrGuía { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
