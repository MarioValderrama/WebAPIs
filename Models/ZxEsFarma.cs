using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxEsFarma
    {
        [Column("CODIGO_MAT")]
        [StringLength(10)]
        public string CodigoMat { get; set; }
        [Column("DESCRI_MAT")]
        [StringLength(80)]
        public string DescriMat { get; set; }
        [Column("UNIMED_MAT")]
        [StringLength(4)]
        public string UnimedMat { get; set; }
        [Column("ESTADO")]
        [StringLength(1)]
        public string Estado { get; set; }
        [Column("FECHA_C", TypeName = "datetime")]
        public DateTime? FechaC { get; set; }
        [StringLength(7)]
        public string Labo { get; set; }
        [Column("CLASE")]
        [StringLength(4)]
        public string Clase { get; set; }
        [Column("DESCRI_CLA")]
        [StringLength(35)]
        public string DescriCla { get; set; }
        [Column("SUBCLASE")]
        [StringLength(4)]
        public string Subclase { get; set; }
        [Column("DESCRI_SCL")]
        [StringLength(35)]
        public string DescriScl { get; set; }
        [Column("Cod_PrAct")]
        [StringLength(4)]
        public string CodPrAct { get; set; }
        [Column("Des_PrAct")]
        [StringLength(80)]
        public string DesPrAct { get; set; }
        [Column("Cl_Terap")]
        [StringLength(4)]
        public string ClTerap { get; set; }
        [Column("Des_ClTer")]
        [StringLength(35)]
        public string DesClTer { get; set; }
        [StringLength(1)]
        public string Farma { get; set; }
        [Column("CODBOD")]
        [StringLength(3)]
        public string Codbod { get; set; }
        public double? Stock { get; set; }
        public double? Reserva { get; set; }
        [Column("Precio Venta")]
        public double? PrecioVenta { get; set; }
        [StringLength(1)]
        public string PetMinimo { get; set; }
    }
}
