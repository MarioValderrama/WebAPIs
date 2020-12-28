using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("INTRAHST")]
    public partial class Intrahst
    {
        [Column("MODULO")]
        [StringLength(3)]
        public string Modulo { get; set; }
        [Column("IDTRA")]
        [StringLength(3)]
        public string Idtra { get; set; }
        [Column("DOC")]
        [StringLength(10)]
        public string Doc { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("HORA")]
        [StringLength(8)]
        public string Hora { get; set; }
        [Column("CODIGOP")]
        [StringLength(10)]
        public string Codigop { get; set; }
        [Column("CODIGOB")]
        [StringLength(14)]
        public string Codigob { get; set; }
        [Column("CODBOD")]
        [StringLength(3)]
        public string Codbod { get; set; }
        [Column("LOCAL")]
        public int? Local { get; set; }
        [Column("CANT_ANT")]
        public double? CantAnt { get; set; }
        [Column("CANT_ACT")]
        public double? CantAct { get; set; }
        [Column("COSTO_ANT")]
        public double? CostoAnt { get; set; }
        [Column("COSTO_ACT")]
        public double? CostoAct { get; set; }
        [Column("CANT_ANT_B")]
        public double? CantAntB { get; set; }
        [Column("CANT_ANT_L")]
        public double? CantAntL { get; set; }
        [Column("CANT_ANT_U")]
        public double? CantAntU { get; set; }
        [Column("CANT_ANT_CB_B")]
        public double? CantAntCbB { get; set; }
        [Column("CANT_ANT_CB_L")]
        public double? CantAntCbL { get; set; }
        [Column("CANT_ANT_CB_U")]
        public double? CantAntCbU { get; set; }
        [Column("LOTE")]
        [StringLength(50)]
        public string Lote { get; set; }
        [Column("UBICA")]
        [StringLength(14)]
        public string Ubica { get; set; }
        [Column("REFERENCIA")]
        [StringLength(10)]
        public string Referencia { get; set; }
        [Column("USUARIO")]
        [StringLength(8)]
        public string Usuario { get; set; }
        public long Id { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
