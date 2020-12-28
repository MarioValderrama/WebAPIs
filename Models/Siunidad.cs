using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIUNIDAD")]
    public partial class Siunidad
    {
        [Key]
        [Column("CODUNI")]
        [StringLength(4)]
        public string Coduni { get; set; }
        [Column("NOMUNI")]
        [StringLength(35)]
        public string Nomuni { get; set; }
    }
}
