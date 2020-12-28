using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("COMPAGOS")]
    public partial class Compagos
    {
        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [StringLength(10)]
        public string Rut { get; set; }
        [StringLength(15)]
        public string NumDoc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaDoc { get; set; }
        public double? MontoDoc { get; set; }
        [StringLength(10)]
        public string Factura { get; set; }
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("Cod_TDoc")]
        [StringLength(4)]
        public string CodTdoc { get; set; }
        [Column("Cod_Ban")]
        [StringLength(4)]
        public string CodBan { get; set; }
        [StringLength(50)]
        public string Observ { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [Column("Banco_Dep")]
        [StringLength(4)]
        public string BancoDep { get; set; }
        [Column("Fecha_Dep", TypeName = "datetime")]
        public DateTime? FechaDep { get; set; }
        [StringLength(1)]
        public string DocaFecha { get; set; }
        [StringLength(10)]
        public string Referencia { get; set; }
        public bool? Regularizado { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
