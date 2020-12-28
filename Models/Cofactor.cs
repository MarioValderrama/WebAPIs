using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("COFACTOR")]
    public partial class Cofactor
    {
        public short? Vendedor { get; set; }
        [Column("FIni", TypeName = "datetime2(0)")]
        public DateTime? Fini { get; set; }
        [Column("FFin", TypeName = "datetime2(0)")]
        public DateTime? Ffin { get; set; }
        public float? Factor { get; set; }
        [Column("Factor_Sup")]
        public float? FactorSup { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
