using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SICOMUNA")]
    public partial class Sicomuna
    {
        [Key]
        [Column("CODCOM")]
        [StringLength(4)]
        public string Codcom { get; set; }
        [Column("NOMCOM")]
        [StringLength(35)]
        public string Nomcom { get; set; }
        [Column("ZONACOM")]
        [StringLength(2)]
        public string Zonacom { get; set; }
    }
}
