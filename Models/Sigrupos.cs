using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIGRUPOS")]
    public partial class Sigrupos
    {
        [Key]
        [StringLength(4)]
        public string CodGrupo { get; set; }
        [StringLength(35)]
        public string DesGrupo { get; set; }
    }
}
