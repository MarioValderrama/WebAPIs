using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIFORFAR")]
    public partial class Siforfar
    {
        [Key]
        [Column("CODIGO_FFA")]
        [StringLength(4)]
        public string CodigoFfa { get; set; }
        [Column("DESCRI_FFA")]
        [StringLength(35)]
        public string DescriFfa { get; set; }
    }
}
