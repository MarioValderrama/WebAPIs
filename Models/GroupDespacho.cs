using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class GroupDespacho
    {
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column("DTfOLIO")]
        public int? DtfOlio { get; set; }
    }
}
