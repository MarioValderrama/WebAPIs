using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("GEOCMENC")]
    public partial class Geocmenc
    {
        [Key]
        [Column("NumOC")]
        [StringLength(10)]
        public string NumOc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [StringLength(10)]
        public string RutPro { get; set; }
        [Column("FPago")]
        [StringLength(4)]
        public string Fpago { get; set; }
        [StringLength(1)]
        public string AfEx { get; set; }
        [StringLength(4)]
        public string CodMon { get; set; }
        [StringLength(100)]
        public string Observ { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(8)]
        public string Usuario { get; set; }
        public float? Iva { get; set; }
        public short? Local { get; set; }
        public short? Días { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
