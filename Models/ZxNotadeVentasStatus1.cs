using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxNotadeVentasStatus1
    {
        [StringLength(10)]
        public string NotaVenta { get; set; }
        [StringLength(10)]
        public string Preparacion { get; set; }
        [Column("Fecha_Preparacion", TypeName = "datetime")]
        public DateTime? FechaPreparacion { get; set; }
        [Column("BODEGA")]
        [StringLength(4)]
        public string Bodega { get; set; }
        public int? Items { get; set; }
        [Column("CANTIDAD")]
        public double? Cantidad { get; set; }
        [Column("CANT_GUIA")]
        public double? CantGuia { get; set; }
        [StringLength(20)]
        public string Estado { get; set; }
        [Column("Cant_Ped")]
        public double? CantPed { get; set; }
        [Column("Cant_Esc")]
        public double? CantEsc { get; set; }
        [Column("Cant_NV")]
        public double? CantNv { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecPed { get; set; }
        [StringLength(10)]
        public string RutCli { get; set; }
        [Column("FPago")]
        [StringLength(4)]
        public string Fpago { get; set; }
        [Column("IDCanal")]
        [StringLength(4)]
        public string Idcanal { get; set; }
        [StringLength(4)]
        public string Zona { get; set; }
        [StringLength(4)]
        public string TipCli { get; set; }
        [StringLength(80)]
        public string Cliente { get; set; }
        [StringLength(80)]
        public string Vendedor { get; set; }
        [StringLength(35)]
        public string Canal { get; set; }
        [Column("Canal Global")]
        [StringLength(35)]
        public string CanalGlobal { get; set; }
        public short? Retenido { get; set; }
        [Column("DESCRI_BOD")]
        [StringLength(35)]
        public string DescriBod { get; set; }
        [Column("DESCRI_LAB")]
        [StringLength(35)]
        public string DescriLab { get; set; }
    }
}
