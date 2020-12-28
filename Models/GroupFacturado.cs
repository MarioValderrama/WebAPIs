using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class GroupFacturado
    {
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column("FTfOLIO")]
        public int? FtfOlio { get; set; }
    }
}
