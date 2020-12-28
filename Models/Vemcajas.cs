using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VEMCAJAS")]
    public partial class Vemcajas
    {
        [Key]
        [StringLength(4)]
        public string CodCaja { get; set; }
        [StringLength(35)]
        public string DesCaja { get; set; }
    }
}
