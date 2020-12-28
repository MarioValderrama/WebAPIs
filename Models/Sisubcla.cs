using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SISUBCLA")]
    public partial class Sisubcla
    {
        [Key]
        [Column("CODIGO_SCL")]
        [StringLength(4)]
        public string CodigoScl { get; set; }
        [Column("DESCRI_SCL")]
        [StringLength(35)]
        public string DescriScl { get; set; }
    }
}
