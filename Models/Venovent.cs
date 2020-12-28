using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VENOVENT")]
    public partial class Venovent
    {
        [Required]
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("FECHA", TypeName = "datetime2(0)")]
        public DateTime Fecha { get; set; }
        [Required]
        [Column("CODBOD")]
        [StringLength(3)]
        public string Codbod { get; set; }
        [Column("LOCAL")]
        public int? Local { get; set; }
        [Column("CAJA")]
        [StringLength(4)]
        public string Caja { get; set; }
        [Column("VENDEDOR")]
        public int? Vendedor { get; set; }
        [Column("USUARIO")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("CODIGO")]
        [StringLength(13)]
        public string Codigo { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("CANTIDAD")]
        public double? Cantidad { get; set; }
        [StringLength(10)]
        public string Cbase { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
