using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VELOCVEN")]
    public partial class Velocven
    {
        [Column("CODLOCAL")]
        public int? Codlocal { get; set; }
        public int? CodVen { get; set; }
    }
}
