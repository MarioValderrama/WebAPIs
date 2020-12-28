using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxPreparacionLg
    {
        [Column("SDDOCO")]
        [StringLength(50)]
        public string Sddoco { get; set; }
        [Column("Lineas PRE")]
        public int? LineasPre { get; set; }
        [Column("Unidades PRE", TypeName = "numeric(38, 0)")]
        public decimal? UnidadesPre { get; set; }
        [Column("Cod_Per")]
        [StringLength(4)]
        public string CodPer { get; set; }
        [StringLength(2)]
        public string Area { get; set; }
        [Column("Lineas LG")]
        public int? LineasLg { get; set; }
        [Column("Unidades LG")]
        public int? UnidadesLg { get; set; }
        [Column("Fecha_T", TypeName = "datetime")]
        public DateTime? FechaT { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [StringLength(3)]
        public string Bodega { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column("Des_Per")]
        [StringLength(35)]
        public string DesPer { get; set; }
    }
}
