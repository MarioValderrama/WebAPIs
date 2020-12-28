using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxConsolidadoImpreped
    {
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("BODEGA")]
        [StringLength(4)]
        public string Bodega { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("CANTIDAD")]
        public double? Cantidad { get; set; }
        [Column("Cant_Ped")]
        public double? CantPed { get; set; }
        [Column("Cant_Esc")]
        public double? CantEsc { get; set; }
        [Column("Cant_NV")]
        public double? CantNv { get; set; }
    }
}
