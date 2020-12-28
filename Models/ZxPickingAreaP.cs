using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxPickingAreaP
    {
        [StringLength(10)]
        public string Documento { get; set; }
        [StringLength(2)]
        public string Area { get; set; }
        [Column("Cod_Per")]
        [StringLength(4)]
        public string CodPer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("Tipo_Doc")]
        [StringLength(1)]
        public string TipoDoc { get; set; }
        [Column("Fecha_T", TypeName = "datetime")]
        public DateTime? FechaT { get; set; }
        public int? Líneas { get; set; }
        public int? Unidades { get; set; }
        public int? Valores { get; set; }
        [StringLength(3)]
        public string Bodega { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
    }
}
