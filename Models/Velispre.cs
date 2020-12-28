using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VELISPRE")]
    public partial class Velispre
    {
        [Key]
        [StringLength(4)]
        public string CodLp { get; set; }
        [StringLength(40)]
        public string DesLp { get; set; }
        [StringLength(1)]
        public string Dato { get; set; }
        [StringLength(1)]
        public string Oper { get; set; }
        public double? Factor { get; set; }
        [StringLength(1)]
        public string Tipo { get; set; }
        [StringLength(1)]
        public string Retiene { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
