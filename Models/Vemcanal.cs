using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VEMCANAL")]
    public partial class Vemcanal
    {
        [Key]
        [StringLength(4)]
        public string CodCanal { get; set; }
        [StringLength(35)]
        public string DesCanal { get; set; }
    }
}
