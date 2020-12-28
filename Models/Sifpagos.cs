using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIFPAGOS")]
    public partial class Sifpagos
    {
        [Key]
        [Column("CODFP")]
        [StringLength(4)]
        public string Codfp { get; set; }
        [Column("NOMFP")]
        [StringLength(35)]
        public string Nomfp { get; set; }
        [Column("DIAS1")]
        public double? Dias1 { get; set; }
        [Column("DIAS2")]
        public double? Dias2 { get; set; }
        [Column("DIAS3")]
        public double? Dias3 { get; set; }
        [Column("DIAS4")]
        public double? Dias4 { get; set; }
        [Column("DIAS5")]
        public double? Dias5 { get; set; }
        [Column("DIAS6")]
        public double? Dias6 { get; set; }
        [Column("DESCUENTO")]
        public double? Descuento { get; set; }
        [Column("FP_dte")]
        public short? FpDte { get; set; }
        [Column("RetNV")]
        public bool? RetNv { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
