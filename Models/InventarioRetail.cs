using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class InventarioRetail
    {
        [Column("CBod")]
        [StringLength(3)]
        public string Cbod { get; set; }
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
        [Column("Stock_")]
        public double? Stock { get; set; }
        public double? Precio { get; set; }
        public double? Oferta { get; set; }
        [Column("Un_x_Caja")]
        public int? UnXCaja { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Vencimiento { get; set; }
        [Column("CI")]
        [StringLength(1)]
        public string Ci { get; set; }
    }
}
