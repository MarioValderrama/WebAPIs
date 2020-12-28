using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZVentasListadoVendedores
    {
        [StringLength(10)]
        public string Código { get; set; }
        [StringLength(60)]
        public string Producto { get; set; }
        public double? Precio { get; set; }
        [Column("Clase_Ter")]
        [StringLength(35)]
        public string ClaseTer { get; set; }
        [Column("CLabo")]
        [StringLength(7)]
        public string Clabo { get; set; }
        [StringLength(35)]
        public string Laboratorio { get; set; }
        public double? Stock { get; set; }
        public double? Mgn { get; set; }
        [Column("Principio_Activo")]
        [StringLength(80)]
        public string PrincipioActivo { get; set; }
        [Column("Clase_Terap")]
        [StringLength(35)]
        public string ClaseTerap { get; set; }
        [Required]
        [StringLength(2)]
        public string Condición { get; set; }
    }
}
