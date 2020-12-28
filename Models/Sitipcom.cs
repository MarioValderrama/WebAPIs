using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SITIPCOM")]
    public partial class Sitipcom
    {
        [Key]
        [Column("CodTCom")]
        [StringLength(4)]
        public string CodTcom { get; set; }
        [Column("DesTCom")]
        [StringLength(35)]
        public string DesTcom { get; set; }
    }
}
