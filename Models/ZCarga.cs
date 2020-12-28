using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("Z_Carga")]
    public partial class ZCarga
    {
        [Column("cod")]
        [StringLength(10)]
        public string Cod { get; set; }
        [Column("descr")]
        [StringLength(100)]
        public string Descr { get; set; }
        [Column("cuc")]
        public double? Cuc { get; set; }
        [Column("ppub")]
        public double? Ppub { get; set; }
        [Column("pofer")]
        public double? Pofer { get; set; }
        [Column("lotex")]
        [StringLength(15)]
        public string Lotex { get; set; }
        [Column("fechax", TypeName = "datetime2(0)")]
        public DateTime? Fechax { get; set; }
        [Column("cbarra")]
        [StringLength(14)]
        public string Cbarra { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
