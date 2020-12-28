using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZzSysPetitorioInventario
    {
        [Column("CODIGO")]
        [StringLength(10)]
        public string Codigo { get; set; }
        [Column("PRODUCTO")]
        [StringLength(60)]
        public string Producto { get; set; }
        [Column("UM")]
        [StringLength(4)]
        public string Um { get; set; }
        [Column("ESTADO")]
        [StringLength(1)]
        public string Estado { get; set; }
        [Column("CREADO", TypeName = "datetime")]
        public DateTime? Creado { get; set; }
        [Column("CLabo")]
        [StringLength(7)]
        public string Clabo { get; set; }
        [Column("CClase")]
        [StringLength(4)]
        public string Cclase { get; set; }
        [Column("CLASE")]
        [StringLength(35)]
        public string Clase { get; set; }
        [Column("CSubClase")]
        [StringLength(4)]
        public string CsubClase { get; set; }
        [Column("SUBCLASE")]
        [StringLength(35)]
        public string Subclase { get; set; }
        [Column("CPrActivo")]
        [StringLength(4)]
        public string CprActivo { get; set; }
        [Column("PRINCIPIO ACTIVO")]
        [StringLength(80)]
        public string PrincipioActivo { get; set; }
        [Column("CClaseTer")]
        [StringLength(4)]
        public string CclaseTer { get; set; }
        [Column("CLASE TERAPEUTICA")]
        [StringLength(35)]
        public string ClaseTerapeutica { get; set; }
        [Column("CBod")]
        [StringLength(3)]
        public string Cbod { get; set; }
        [Column("STOCK")]
        public double? Stock { get; set; }
        [Column("PRECIO")]
        public double? Precio { get; set; }
        [Column("En Petitorio?")]
        [StringLength(1)]
        public string EnPetitorio { get; set; }
    }
}
