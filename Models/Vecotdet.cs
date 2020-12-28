using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VECOTDET")]
    public partial class Vecotdet
    {
        [StringLength(10)]
        public string NumCot { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecCot { get; set; }
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
        public double? Costo { get; set; }
        public double? CantPed { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
