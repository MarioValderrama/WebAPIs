using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class InventarioDisponible993
    {
        [StringLength(3)]
        public string CodBod { get; set; }
        [StringLength(35)]
        public string Bodega { get; set; }
        [Column("CClase")]
        [StringLength(4)]
        public string Cclase { get; set; }
        [StringLength(35)]
        public string Clase { get; set; }
        [Column("CLabo")]
        [StringLength(7)]
        public string Clabo { get; set; }
        [StringLength(35)]
        public string Laboratorio { get; set; }
        [StringLength(10)]
        public string Código { get; set; }
        [StringLength(60)]
        public string Producto { get; set; }
        public double? Disponible { get; set; }
        public double? Costp { get; set; }
        [Column("Un_x_Caja")]
        public int? UnXCaja { get; set; }
    }
}
