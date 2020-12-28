using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class SimaerutClientes
    {
        [Column("RUTPRO")]
        [StringLength(10)]
        public string Rutpro { get; set; }
        [Column("DV")]
        [StringLength(1)]
        public string Dv { get; set; }
        [Column("IDENTIFICADOR")]
        [StringLength(80)]
        public string Identificador { get; set; }
        [Column("APELLIDOS")]
        [StringLength(50)]
        public string Apellidos { get; set; }
        [Column("TIPO")]
        [StringLength(1)]
        public string Tipo { get; set; }
    }
}
