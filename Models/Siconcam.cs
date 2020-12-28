using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SICONCAM")]
    public partial class Siconcam
    {
        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [StringLength(15)]
        public string Versión { get; set; }
        [StringLength(80)]
        public string Descripción { get; set; }
    }
}
