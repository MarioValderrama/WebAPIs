using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("LGTRANSP")]
    public partial class Lgtransp
    {
        [Key]
        [Column("CodTRans")]
        [StringLength(4)]
        public string CodTrans { get; set; }
        [StringLength(35)]
        public string DesTrans { get; set; }
        [StringLength(1)]
        public string TipoTrans { get; set; }
    }
}
