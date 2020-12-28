using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("INDPRENC")]
    public partial class Indprenc
    {
        [Key]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("FECHA", TypeName = "datetime2(0)")]
        public DateTime? Fecha { get; set; }
        public short? Local { get; set; }
        [Column("BODEGA")]
        [StringLength(4)]
        public string Bodega { get; set; }
        [Column("OBSERVACION")]
        [StringLength(100)]
        public string Observacion { get; set; }
        [StringLength(10)]
        public string Referencia { get; set; }
        [StringLength(8)]
        public string Usuario { get; set; }
        [StringLength(10)]
        public string RutPrv { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(1)]
        public string Tipo { get; set; }
        [Column("TDocs")]
        public double? Tdocs { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
