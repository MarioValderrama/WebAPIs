using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("LGMTRANS")]
    public partial class Lgmtrans
    {
        [Key]
        [Column("TR_Cod")]
        [StringLength(4)]
        public string TrCod { get; set; }
        [Column("TR_Desc")]
        [StringLength(35)]
        public string TrDesc { get; set; }
        [Column("TR_Peso_Kg")]
        public float? TrPesoKg { get; set; }
        [Column("TR_Peso_Vol")]
        public float? TrPesoVol { get; set; }
        [Column("TR_Observ")]
        [StringLength(255)]
        public string TrObserv { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
