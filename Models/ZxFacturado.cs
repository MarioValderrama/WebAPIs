using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxFacturado
    {
        [StringLength(10)]
        public string NumPed { get; set; }
        [StringLength(10)]
        public string CodBase { get; set; }
        [Column("CANT")]
        public float? Cant { get; set; }
        [Column("PRECIO")]
        public double? Precio { get; set; }
        public double? Costo { get; set; }
        public double? ValorT { get; set; }
        public double? CantPrep { get; set; }
        public double? CantFact { get; set; }
        [Column("CantNC")]
        public int? CantNc { get; set; }
        [Column("CantND")]
        public int? CantNd { get; set; }
        [Column("COSTO_PROM")]
        public double? CostoProm { get; set; }
        [Column("INC_VALOR")]
        public double? IncValor { get; set; }
        [Column("INC_PORC")]
        public double? IncPorc { get; set; }
        [Column("DESCRI_LAB")]
        [StringLength(35)]
        public string DescriLab { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecPed { get; set; }
        [Column("DESCRI_COM")]
        [StringLength(60)]
        public string DescriCom { get; set; }
    }
}
