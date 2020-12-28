using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxGuiayPreparacion
    {
        [StringLength(10)]
        public string Guias { get; set; }
        [StringLength(10)]
        public string Preparacion { get; set; }
    }
}
