using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxListadoVendedores
    {
        [Required]
        [Column("RUTPRO")]
        [StringLength(10)]
        public string Rutpro { get; set; }
        [Column("DV")]
        [StringLength(1)]
        public string Dv { get; set; }
        [Column("IDENTIFICADOR")]
        [StringLength(80)]
        public string Identificador { get; set; }
        [Column("VENDEDOR")]
        [StringLength(1)]
        public string Vendedor { get; set; }
        [StringLength(4)]
        public string Zona { get; set; }
        [Column("CODIGOI")]
        public int? Codigoi { get; set; }
    }
}
