using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class SicomunaDatos
    {
        [Column("CODCOM")]
        [StringLength(4)]
        public string Codcom { get; set; }
        [Column("NOMCOM")]
        [StringLength(35)]
        public string Nomcom { get; set; }
    }
}
