using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZzSysNotasDeVentaRepaso
    {
        [Required]
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecPed { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        public short? NumLin { get; set; }
        [StringLength(10)]
        public string CodBase { get; set; }
        public float? Cantidad { get; set; }
        [Column("PRECIO")]
        public double? Precio { get; set; }
        public int? Flete { get; set; }
        public int? Unidades { get; set; }
        public int? Vend { get; set; }
        public short? Parcial { get; set; }
        [StringLength(10)]
        public string RutCli { get; set; }
    }
}
