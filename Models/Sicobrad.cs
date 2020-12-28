using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SICOBRAD")]
    public partial class Sicobrad
    {
        [Key]
        [Column("COD_COB")]
        [StringLength(4)]
        public string CodCob { get; set; }
        [Column("NOM_COB")]
        [StringLength(35)]
        public string NomCob { get; set; }
    }
}
