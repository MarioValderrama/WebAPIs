using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZzSysOrdenesDeCompraPendientes
    {
        [StringLength(10)]
        public string CodBase { get; set; }
        [Column("pendienteoc_final")]
        public double? PendienteocFinal { get; set; }
    }
}
