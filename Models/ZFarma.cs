using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("Z_Farma")]
    public partial class ZFarma
    {
        [StringLength(10)]
        public string Codigo { get; set; }
        [StringLength(100)]
        public string Descripcion { get; set; }
        public short? Farma { get; set; }
    }
}
