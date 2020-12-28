using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIMONEDA")]
    public partial class Simoneda
    {
        [Column("COD_MON")]
        [StringLength(4)]
        public string CodMon { get; set; }
        [Column("DES_MON")]
        [StringLength(35)]
        public string DesMon { get; set; }
        [Column("SIG_MON")]
        [StringLength(4)]
        public string SigMon { get; set; }
    }
}
