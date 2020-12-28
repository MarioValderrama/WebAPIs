using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZzSysNotasDeVentaPendientes
    {
        [StringLength(10)]
        public string CodBase { get; set; }
        [Column("pendientenv_final")]
        public double? PendientenvFinal { get; set; }
    }
}
