using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VEGUIDET")]
    public partial class Veguidet
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
        [Column("VENCE", TypeName = "datetime2(0)")]
        public DateTime? Vence { get; set; }
        [Column("MOTIVO")]
        [StringLength(4)]
        public string Motivo { get; set; }
        [Column("OBSERVACION")]
        [StringLength(50)]
        public string Observacion { get; set; }
        [Column("Cant_Fact")]
        public double? CantFact { get; set; }
        public double? Costop { get; set; }
        public int? LinPed { get; set; }
        public double? PrecioP { get; set; }
        [Column("NC")]
        public int? Nc { get; set; }
        [StringLength(1)]
        public string EsNc { get; set; }
        [StringLength(1)]
        public string EstGuia { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
