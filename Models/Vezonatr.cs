using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VEZONATR")]
    public partial class Vezonatr
    {
        [Column("ZONA")]
        public short? Zona { get; set; }
        [Column("PESOA")]
        public float? Pesoa { get; set; }
        [Column("PESOB")]
        public float? Pesob { get; set; }
        [Column("VALOR")]
        public int? Valor { get; set; }
        [Column("ZN_cod")]
        [StringLength(4)]
        public string ZnCod { get; set; }
        [Column("TR_cod")]
        [StringLength(4)]
        public string TrCod { get; set; }
        public int? Mínimo { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
