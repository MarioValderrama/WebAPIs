using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxLineasPreparas
    {
        [Column("Cod_Per")]
        [StringLength(4)]
        public string CodPer { get; set; }
        [Column("Des_Per")]
        [StringLength(35)]
        public string DesPer { get; set; }
        [Column("Fecha_Inicio_P", TypeName = "datetime")]
        public DateTime? FechaInicioP { get; set; }
        [Column("Estado de Proceso")]
        [StringLength(50)]
        public string EstadoDeProceso { get; set; }
        [StringLength(50)]
        public string Area { get; set; }
        [Column("DESCRI_BOD")]
        [StringLength(35)]
        public string DescriBod { get; set; }
        [Column("Fecha_Preparacion", TypeName = "datetime")]
        public DateTime? FechaPreparacion { get; set; }
        [Column("Fecha_T", TypeName = "datetime")]
        public DateTime? FechaT { get; set; }
        [StringLength(10)]
        public string Documento { get; set; }
        public int? Mes { get; set; }
        public int? Dia { get; set; }
        [Column("LineasNN")]
        public int? LineasNn { get; set; }
        [Column("UnidadesNN")]
        public double? UnidadesNn { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
        public int? LineasN { get; set; }
        public int? UnidadesN { get; set; }
    }
}
