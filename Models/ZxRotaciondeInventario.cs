using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxRotaciondeInventario
    {
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("BODEGA")]
        [StringLength(4)]
        public string Bodega { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("Cantidad_Despachada")]
        public double? CantidadDespachada { get; set; }
        [Column("DESCRI_BOD")]
        [StringLength(35)]
        public string DescriBod { get; set; }
        [Column("DESCRI_COM")]
        [StringLength(60)]
        public string DescriCom { get; set; }
        [StringLength(7)]
        public string Labo { get; set; }
        [Column("DESCRI_LAB")]
        [StringLength(35)]
        public string DescriLab { get; set; }
        public double? Costo { get; set; }
    }
}
