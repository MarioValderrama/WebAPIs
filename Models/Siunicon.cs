using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIUNICON")]
    public partial class Siunicon
    {
        [Column("UNIBASE")]
        [StringLength(4)]
        public string Unibase { get; set; }
        [Column("UNIDEST")]
        [StringLength(4)]
        public string Unidest { get; set; }
        [Column("FACTORC")]
        public double Factorc { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
