using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("LGCUBDSE")]
    public partial class Lgcubdse
    {
        [StringLength(10)]
        public string Documento { get; set; }
        [StringLength(15)]
        public string Seguro { get; set; }
        public int? Orden { get; set; }
        [StringLength(15)]
        public string Cubeta { get; set; }
        [StringLength(10)]
        public string FolPrep { get; set; }
    }
}
