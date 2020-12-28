using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SICAJMOV")]
    public partial class Sicajmov
    {
        [Column("CAJA")]
        [StringLength(4)]
        public string Caja { get; set; }
        [Column("LOCAL")]
        public int? Local { get; set; }
        [Column("FECHA_AP", TypeName = "datetime2(0)")]
        public DateTime? FechaAp { get; set; }
        [Column("DOC_AP")]
        public double? DocAp { get; set; }
        [Column("SALDO_AP")]
        public int? SaldoAp { get; set; }
        [Column("FECHA_CI", TypeName = "datetime2(0)")]
        public DateTime? FechaCi { get; set; }
        [Column("DOC_CI")]
        public double? DocCi { get; set; }
        [Column("SALDO_CI")]
        public int? SaldoCi { get; set; }
        [Column("USUARIO")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("VENDEDOR")]
        public int? Vendedor { get; set; }
        [StringLength(1)]
        public string Fijo { get; set; }
        [Column("USUARIO_CI")]
        [StringLength(8)]
        public string UsuarioCi { get; set; }
        [Column("id_tr")]
        public int IdTr { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
