using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VETIPCLI")]
    public partial class Vetipcli
    {
        [Key]
        [Column("CodTCli")]
        [StringLength(4)]
        public string CodTcli { get; set; }
        [Column("DesTCli")]
        [StringLength(35)]
        public string DesTcli { get; set; }
    }
}
