using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SICIUDAD")]
    public partial class Siciudad
    {
        [Key]
        [StringLength(4)]
        public string CodCi { get; set; }
        [StringLength(35)]
        public string NomCi { get; set; }
        [StringLength(3)]
        public string Zona1 { get; set; }
        [StringLength(3)]
        public string Zona2 { get; set; }
    }
}
