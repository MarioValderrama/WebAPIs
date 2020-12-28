using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("INENTENC")]
    public partial class Inentenc
    {
        [Key]
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [Required]
        [Column("CODBOD")]
        [StringLength(3)]
        public string Codbod { get; set; }
        [Column("TIPODOC")]
        [StringLength(1)]
        public string Tipodoc { get; set; }
        [Column("NUMERODOC")]
        [StringLength(20)]
        public string Numerodoc { get; set; }
        [Column("FABRICA")]
        [StringLength(30)]
        public string Fabrica { get; set; }
        [Column("OC")]
        [StringLength(10)]
        public string Oc { get; set; }
        [Column("FECHAOC", TypeName = "datetime")]
        public DateTime? Fechaoc { get; set; }
        [Column("PROVEEDOR")]
        [StringLength(80)]
        public string Proveedor { get; set; }
        [Column("OBSERV")]
        [StringLength(50)]
        public string Observ { get; set; }
        [Column("IMPRESO")]
        [StringLength(1)]
        public string Impreso { get; set; }
        [Column("ESTADO")]
        [StringLength(1)]
        public string Estado { get; set; }
        [Column("USUARIOA")]
        [StringLength(8)]
        public string Usuarioa { get; set; }
        [Column("FECHAA", TypeName = "datetime")]
        public DateTime? Fechaa { get; set; }
        [StringLength(1)]
        public string AfEx { get; set; }
        public double? Impuesto { get; set; }
        public int? Local { get; set; }
        [Column("CCosto")]
        [StringLength(7)]
        public string Ccosto { get; set; }
        [StringLength(10)]
        public string RutPrv { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaDoc { get; set; }
        public int? DiasPago { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaVenc { get; set; }
        public short? Contabilizado { get; set; }
        public bool? Pagado { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
