using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class VepeddetProducto
    {
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecPed { get; set; }
        public short? NumLin { get; set; }
        [StringLength(10)]
        public string CodBase { get; set; }
        [Column("CANT")]
        public float? Cant { get; set; }
        [Column("CODUNI")]
        [StringLength(2)]
        public string Coduni { get; set; }
        [Column("PRECIO")]
        public double? Precio { get; set; }
        public double? ValorT { get; set; }
        public double? Costo { get; set; }
        public double? CantGuia { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecEnt { get; set; }
        public double? CantPrep { get; set; }
        public double? CantFact { get; set; }
        [Column("CantNC")]
        public int? CantNc { get; set; }
        [Column("CantND")]
        public int? CantNd { get; set; }
        public int? CantVir { get; set; }
        public int? CantRes { get; set; }
        [Column("Prec_esp")]
        public float? PrecEsp { get; set; }
        [Column("Prec_Of")]
        public float? PrecOf { get; set; }
        [Column("Prec_Ref")]
        public float? PrecRef { get; set; }
    }
}
