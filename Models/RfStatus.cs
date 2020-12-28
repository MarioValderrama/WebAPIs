using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("RF_Status")]
    public partial class RfStatus
    {
        [StringLength(50)]
        public string Status { get; set; }
        [StringLength(50)]
        public string Area { get; set; }
    }
}
