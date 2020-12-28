using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VETIPVEN")]
    public partial class Vetipven
    {
        [Key]
        [Column("CodTVen")]
        [StringLength(4)]
        public string CodTven { get; set; }
        [Column("DesTVen")]
        [StringLength(35)]
        public string DesTven { get; set; }
    }
}
