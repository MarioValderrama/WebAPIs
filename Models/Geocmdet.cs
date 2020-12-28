using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("GEOCMDET")]
    public partial class Geocmdet
    {
        [Column("NUMOC")]
        [StringLength(10)]
        public string Numoc { get; set; }
        [Column("FechaOC", TypeName = "datetime")]
        public DateTime? FechaOc { get; set; }
        public short? NumLin { get; set; }
        [StringLength(10)]
        public string CodBase { get; set; }
        [Column("CANT")]
        public double? Cant { get; set; }
        [Column("CODUNI")]
        [StringLength(4)]
        public string Coduni { get; set; }
        [Column("PRECIO")]
        public double? Precio { get; set; }
        public double? ValorT { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaEnt { get; set; }
        public double? CantRec { get; set; }
        [Column("ESTADO")]
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(35)]
        public string Observ { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
