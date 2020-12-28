using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("COARCHFO")]
    public partial class Coarchfo
    {
        public int? Folio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Desde { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Hasta { get; set; }
        [StringLength(255)]
        public string Archivo { get; set; }
        [StringLength(1)]
        public string Tipo { get; set; }
    }
}
