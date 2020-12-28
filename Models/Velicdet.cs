using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VELICDET")]
    public partial class Velicdet
    {
        [Column("IDLic")]
        [StringLength(25)]
        public string Idlic { get; set; }
        [Column(TypeName = "datetime2(0)")]
        public DateTime? FecLic { get; set; }
        public short? NumLin { get; set; }
        [StringLength(10)]
        public string CodBase { get; set; }
        public int? Cant { get; set; }
        [Column("CODUNI")]
        [StringLength(2)]
        public string Coduni { get; set; }
        [Column("PRECIO")]
        public double? Precio { get; set; }
        public double? ValorT { get; set; }
        public double? Costo { get; set; }
        public int? CantLic { get; set; }
        public int? CantDesp { get; set; }
        [Column("CantNC")]
        public int? CantNc { get; set; }
        [Column("CantND")]
        public int? CantNd { get; set; }
        public int? Saldo { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
