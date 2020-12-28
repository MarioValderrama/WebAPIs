using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("COMMETAS")]
    public partial class Commetas
    {
        public short? Vendedor { get; set; }
        [Column("FIni", TypeName = "datetime2(0)")]
        public DateTime? Fini { get; set; }
        [Column("FFin", TypeName = "datetime2(0)")]
        public DateTime? Ffin { get; set; }
        public double? Venta { get; set; }
        public double? Contribución { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
