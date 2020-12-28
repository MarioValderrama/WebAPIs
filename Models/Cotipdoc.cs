using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("COTIPDOC")]
    public partial class Cotipdoc
    {
        [Key]
        [Column("Cod_TDoc")]
        [StringLength(4)]
        public string CodTdoc { get; set; }
        [Column("Des_TDoc")]
        [StringLength(35)]
        public string DesTdoc { get; set; }
    }
}
