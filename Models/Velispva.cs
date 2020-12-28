using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VELISPVA")]
    public partial class Velispva
    {
        [StringLength(4)]
        public string CodLp { get; set; }
        [StringLength(10)]
        public string CodPro { get; set; }
        [Column("VNeto")]
        public double? Vneto { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
