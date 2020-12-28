using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIGRUASO")]
    public partial class Sigruaso
    {
        [Required]
        [StringLength(4)]
        public string CodGrupo { get; set; }
        [Required]
        [StringLength(10)]
        public string CodArt { get; set; }
    }
}
