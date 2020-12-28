using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIGIROSR")]
    public partial class Sigirosr
    {
        [Column("CODG")]
        [StringLength(4)]
        public string Codg { get; set; }
        [Column("NOMG")]
        [StringLength(40)]
        public string Nomg { get; set; }
    }
}
