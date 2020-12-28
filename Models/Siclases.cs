using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SICLASES")]
    public partial class Siclases
    {
        [Key]
        [Column("CODIGO_CLA")]
        [StringLength(4)]
        public string CodigoCla { get; set; }
        [Column("DESCRI_CLA")]
        [StringLength(35)]
        public string DescriCla { get; set; }
    }
}
