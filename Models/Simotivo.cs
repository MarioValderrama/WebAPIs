using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIMOTIVO")]
    public partial class Simotivo
    {
        [Column("COD_MOTIVO")]
        [StringLength(4)]
        public string CodMotivo { get; set; }
        [Column("DES_MOTIVO")]
        [StringLength(50)]
        public string DesMotivo { get; set; }
    }
}
