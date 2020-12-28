using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VEMZONAS")]
    public partial class Vemzonas
    {
        [Key]
        [StringLength(4)]
        public string CodZona { get; set; }
        [StringLength(35)]
        public string DesZona { get; set; }
    }
}
