using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("COPAGTBK")]
    public partial class Copagtbk
    {
        [StringLength(10)]
        public string Factura { get; set; }
        [StringLength(1)]
        public string Tarjeta { get; set; }
        public double? Monto { get; set; }
        public int? Cuotas { get; set; }
        [StringLength(35)]
        public string Observación { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
