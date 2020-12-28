using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class SimacodbBuscarDuplicados
    {
        [Column("CODIGOB")]
        [StringLength(14)]
        public string Codigob { get; set; }
        [Column("CODIGOP")]
        [StringLength(10)]
        public string Codigop { get; set; }
    }
}
