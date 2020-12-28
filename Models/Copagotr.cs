using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("COPAGOTR")]
    public partial class Copagotr
    {
        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [StringLength(10)]
        public string Documento { get; set; }
        [StringLength(1)]
        public string Tipo { get; set; }
        public double? Monto { get; set; }
        [StringLength(1)]
        public string Movimiento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaDoc { get; set; }
        [StringLength(4)]
        public string CodBanco { get; set; }
        [Column("NSerie")]
        [StringLength(20)]
        public string Nserie { get; set; }
        [StringLength(50)]
        public string Observaciones { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
