using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxCountPreparaciones
    {
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        public double? TotalUni { get; set; }
    }
}
