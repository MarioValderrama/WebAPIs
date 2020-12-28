using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIPRACTI")]
    public partial class Sipracti
    {
        [Key]
        [Column("Cod_PrAct")]
        [StringLength(4)]
        public string CodPrAct { get; set; }
        [Column("Des_PrAct")]
        [StringLength(80)]
        public string DesPrAct { get; set; }
    }
}
