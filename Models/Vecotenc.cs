using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VECOTENC")]
    public partial class Vecotenc
    {
        [Key]
        [StringLength(10)]
        public string NumCot { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecCot { get; set; }
        [StringLength(10)]
        public string RutCli { get; set; }
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
        public double? Iva { get; set; }
        public int? Local { get; set; }
        [StringLength(4)]
        public string TipVen { get; set; }
        [StringLength(4)]
        public string Canal { get; set; }
        [StringLength(4)]
        public string Zona { get; set; }
        [StringLength(4)]
        public string TipCli { get; set; }
        [StringLength(4)]
        public string LisPre { get; set; }
        public int? Vend { get; set; }
        [StringLength(4)]
        public string Ciudad { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
