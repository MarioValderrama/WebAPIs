using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIPAISES")]
    public partial class Sipaises
    {
        [Column("CODPA")]
        [StringLength(4)]
        public string Codpa { get; set; }
        [Column("NOMPA")]
        [StringLength(35)]
        public string Nompa { get; set; }
    }
}
