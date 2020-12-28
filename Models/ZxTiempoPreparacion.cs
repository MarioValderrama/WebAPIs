using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxTiempoPreparacion
    {
        [StringLength(2)]
        public string Area { get; set; }
        [StringLength(10)]
        public string Documento { get; set; }
        [Column("Cod_Per")]
        [StringLength(4)]
        public string CodPer { get; set; }
        [Column("Des_Per")]
        [StringLength(35)]
        public string DesPer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("Fecha_T", TypeName = "datetime")]
        public DateTime? FechaT { get; set; }
        public int? Líneas { get; set; }
        public int? Unidades { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
        [StringLength(3)]
        public string Bodega { get; set; }
        [Column("DESCRI_BOD")]
        [StringLength(35)]
        public string DescriBod { get; set; }
        [Column("TiempoMM")]
        public int? TiempoMm { get; set; }
        public int? Mes { get; set; }
        public int? Año { get; set; }
        public int? Valores { get; set; }
        [Column("Tipo_Doc")]
        [StringLength(1)]
        public string TipoDoc { get; set; }
        [StringLength(4)]
        public string Canal { get; set; }
        [StringLength(4)]
        public string Zona { get; set; }
        [StringLength(35)]
        public string DesCanal { get; set; }
        public int? TiempoMinutos { get; set; }
        public int? TiempoHoras { get; set; }
        public int? TiempoDias { get; set; }
        public int? TiempoSegundos { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
    }
}
