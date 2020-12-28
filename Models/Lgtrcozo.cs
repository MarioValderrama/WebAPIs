using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("LGTRCOZO")]
    public partial class Lgtrcozo
    {
        [Required]
        [Column("TR_Cod")]
        [StringLength(4)]
        public string TrCod { get; set; }
        [Column("Cod_Com")]
        [StringLength(4)]
        public string CodCom { get; set; }
        [Column("ZN_Cod")]
        [StringLength(4)]
        public string ZnCod { get; set; }
        [StringLength(25)]
        public string Observaciones { get; set; }
    }
}
