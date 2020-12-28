using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class InprepedCantGuiaCant
    {
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("LOCAL")]
        public short? Local { get; set; }
        [Column("BODEGA")]
        [StringLength(4)]
        public string Bodega { get; set; }
        [Column("CODIGOB")]
        [StringLength(14)]
        public string Codigob { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("CANTIDAD")]
        public float? Cantidad { get; set; }
        [Column("CODUNI")]
        [StringLength(2)]
        public string Coduni { get; set; }
        [Column("CODUNIR")]
        [StringLength(2)]
        public string Codunir { get; set; }
        [Column("FACTORV")]
        public float? Factorv { get; set; }
        [Column("LOTE")]
        [StringLength(15)]
        public string Lote { get; set; }
        [Column("UBICACION")]
        [StringLength(14)]
        public string Ubicacion { get; set; }
        [Column("VENCE", TypeName = "datetime")]
        public DateTime? Vence { get; set; }
        [Column("MOTIVO")]
        [StringLength(4)]
        public string Motivo { get; set; }
        [Column("OBSERVACION")]
        [StringLength(4)]
        public string Observacion { get; set; }
        [Column("CANT_GUIA")]
        public float? CantGuia { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
        public float? Costop { get; set; }
        public int? LinPed { get; set; }
        [Column("Cant_ant")]
        public float? CantAnt { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(1)]
        public string EstPrep { get; set; }
        [Column("Cant_hst")]
        public float? CantHst { get; set; }
    }
}
