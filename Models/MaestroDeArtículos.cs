using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class MaestroDeArtículos
    {
        [Required]
        [StringLength(10)]
        public string Código { get; set; }
        [StringLength(80)]
        public string Descripción { get; set; }
        [StringLength(60)]
        public string Compras { get; set; }
        [StringLength(60)]
        public string Resumida { get; set; }
        [StringLength(1)]
        public string Est { get; set; }
        [Column("UM")]
        [StringLength(4)]
        public string Um { get; set; }
        [Column("Cód Clase")]
        [StringLength(4)]
        public string CódClase { get; set; }
        [StringLength(35)]
        public string Clase { get; set; }
        [Column("Cód Laboratorio")]
        [StringLength(7)]
        public string CódLaboratorio { get; set; }
        [StringLength(35)]
        public string Laboratorio { get; set; }
        [Column("CONTROLADO")]
        [StringLength(1)]
        public string Controlado { get; set; }
        [Column("Precio Venta")]
        public double? PrecioVenta { get; set; }
        [Column("Costo Promedio")]
        public double? CostoPromedio { get; set; }
        [Column("Costo Ult Compra")]
        public double? CostoUltCompra { get; set; }
        [Column("Fecha Ult Compra", TypeName = "datetime")]
        public DateTime? FechaUltCompra { get; set; }
        [Column("Precio Referencia")]
        public double? PrecioReferencia { get; set; }
        [Column("Precio Portal")]
        public double? PrecioPortal { get; set; }
        [Column("Precio Oferta")]
        public double? PrecioOferta { get; set; }
        [Column("Fecha Exp Oferta", TypeName = "datetime")]
        public DateTime? FechaExpOferta { get; set; }
        public int? Cons1 { get; set; }
        public int? Cons2 { get; set; }
        public int? Cons3 { get; set; }
        public int? Cons4 { get; set; }
        public int? Cons5 { get; set; }
        public int? Cons6 { get; set; }
        [Column("Pendiente Recepción")]
        public int? PendienteRecepción { get; set; }
        public float? Peso { get; set; }
        [Column("CFcv")]
        [StringLength(10)]
        public string Cfcv { get; set; }
    }
}
