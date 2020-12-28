using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VENOTDET")]
    public partial class Venotdet
    {
        [StringLength(10)]
        public string NumDoc { get; set; }
        [StringLength(2)]
        public string Tipo { get; set; }
        public string Glosa { get; set; }
        [StringLength(20)]
        public string Referencia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRef { get; set; }
        [Column("clave01")]
        [StringLength(12)]
        public string Clave01 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaDoc { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
