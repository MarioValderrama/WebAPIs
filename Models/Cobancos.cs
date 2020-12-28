using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("COBANCOS")]
    public partial class Cobancos
    {
        [Key]
        [Column("Cod_Ban")]
        [StringLength(4)]
        public string CodBan { get; set; }
        [Column("Des_Ban")]
        [StringLength(35)]
        public string DesBan { get; set; }
        [Column("Cta_Asoc")]
        [StringLength(15)]
        public string CtaAsoc { get; set; }
    }
}
