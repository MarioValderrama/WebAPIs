using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxStatusdeNv
    {
        [StringLength(80)]
        public string Cliente { get; set; }
        [Column("FPago")]
        [StringLength(4)]
        public string Fpago { get; set; }
        [StringLength(4)]
        public string Zona { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecPed { get; set; }
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("BODEGA")]
        [StringLength(4)]
        public string Bodega { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        [StringLength(35)]
        public string Canal { get; set; }
        [StringLength(80)]
        public string Vendedor { get; set; }
        public int? Lineas { get; set; }
        public double? Unidades { get; set; }
        [Column("DESCRI_BOD")]
        [StringLength(35)]
        public string DescriBod { get; set; }
        [StringLength(1)]
        public string EstPrep { get; set; }
        public short? Retenido { get; set; }
        [Column("DesTCli")]
        [StringLength(35)]
        public string DesTcli { get; set; }
    }
}
