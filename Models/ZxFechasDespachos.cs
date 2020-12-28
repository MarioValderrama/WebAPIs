using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxFechasDespachos
    {
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column("Fecha_Despacho", TypeName = "datetime")]
        public DateTime? FechaDespacho { get; set; }
        [StringLength(10)]
        public string NumGuia { get; set; }
    }
}
