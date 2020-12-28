using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("LGMZONAS")]
    public partial class Lgmzonas
    {
        [Key]
        [Column("ZN_Cod")]
        [StringLength(4)]
        public string ZnCod { get; set; }
        [Column("ZN_Desc")]
        [StringLength(35)]
        public string ZnDesc { get; set; }
    }
}
