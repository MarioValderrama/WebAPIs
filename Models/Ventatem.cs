using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VENTATEM")]
    public partial class Ventatem
    {
        [Key]
        [Column("CODIGO")]
        [StringLength(20)]
        public string Codigo { get; set; }
        [Column("SAL1")]
        public double? Sal1 { get; set; }
        [Column("SAL2")]
        public double? Sal2 { get; set; }
        [Column("SAL3")]
        public double? Sal3 { get; set; }
        [Column("SAL4")]
        public double? Sal4 { get; set; }
        [Column("SAL5")]
        public double? Sal5 { get; set; }
        [Column("SAL6")]
        public double? Sal6 { get; set; }
        [Column("SAL7")]
        public double? Sal7 { get; set; }
        [Column("SAL8")]
        public double? Sal8 { get; set; }
        [Column("SAL9")]
        public double? Sal9 { get; set; }
        [Column("SAL10")]
        public double? Sal10 { get; set; }
        [Column("SAL11")]
        public double? Sal11 { get; set; }
        [Column("SAL12")]
        public double? Sal12 { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
