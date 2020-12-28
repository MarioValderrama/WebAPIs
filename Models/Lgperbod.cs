using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("LGPERBOD")]
    public partial class Lgperbod
    {
        [Required]
        [Column("Cod_Per")]
        [StringLength(4)]
        public string CodPer { get; set; }
        [Required]
        [Column("Cod_Bod")]
        [StringLength(3)]
        public string CodBod { get; set; }
        [StringLength(1)]
        public string Area { get; set; }
    }
}
