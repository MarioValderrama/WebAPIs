using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VELICENC")]
    public partial class Velicenc
    {
        [Key]
        [Column("IDLic")]
        [StringLength(25)]
        public string Idlic { get; set; }
        [Column(TypeName = "datetime2(0)")]
        public DateTime? FecLic { get; set; }
        [StringLength(10)]
        public string RutCli { get; set; }
        public int? Duración { get; set; }
        [Column(TypeName = "datetime2(0)")]
        public DateTime? Desde { get; set; }
        [Column(TypeName = "datetime2(0)")]
        public DateTime? Hasta { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(8)]
        public string Usuario { get; set; }
        public int? Local { get; set; }
        [StringLength(4)]
        public string TipVen { get; set; }
        [StringLength(4)]
        public string Canal { get; set; }
        [StringLength(4)]
        public string Zona { get; set; }
        [StringLength(4)]
        public string TipCli { get; set; }
        public int? Vend { get; set; }
        [StringLength(100)]
        public string Observ { get; set; }
    }
}
