using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZzSysNcFactura
    {
        [Column("Folio_Ref")]
        [StringLength(10)]
        public string FolioRef { get; set; }
        [Column("Valor_Ref")]
        public double? ValorRef { get; set; }
        [Column("Big_numero")]
        public long? BigNumero { get; set; }
    }
}
