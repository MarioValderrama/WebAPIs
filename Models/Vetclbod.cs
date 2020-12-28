using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VETCLBOD")]
    public partial class Vetclbod
    {
        [Column("CodTCli")]
        [StringLength(4)]
        public string CodTcli { get; set; }
        [Column("CODBOD")]
        [StringLength(3)]
        public string Codbod { get; set; }
        public int? Prioridad { get; set; }
    }
}
