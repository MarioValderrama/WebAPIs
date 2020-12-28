using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SICLTERA")]
    public partial class Sicltera
    {
        [Key]
        [Column("Cod_ClTer")]
        [StringLength(4)]
        public string CodClTer { get; set; }
        [Column("Des_ClTer")]
        [StringLength(35)]
        public string DesClTer { get; set; }
    }
}
