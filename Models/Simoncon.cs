using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIMONCON")]
    public partial class Simoncon
    {
        [Column("CODA")]
        [StringLength(4)]
        public string Coda { get; set; }
        [Column("CODD")]
        [StringLength(4)]
        public string Codd { get; set; }
        [Column("FECHA", TypeName = "datetime2(0)")]
        public DateTime? Fecha { get; set; }
        [Column("FACTOR")]
        public double? Factor { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
