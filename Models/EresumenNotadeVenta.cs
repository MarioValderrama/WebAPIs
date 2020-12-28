using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class EresumenNotadeVenta
    {
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecPed { get; set; }
        [Column("T-Prep")]
        public int? TPrep { get; set; }
        [Column("T-Unid")]
        public double? TUnid { get; set; }
        [Column("IDENTIFICADOR")]
        [StringLength(80)]
        public string Identificador { get; set; }
        [Column("DesTCli")]
        [StringLength(35)]
        public string DesTcli { get; set; }
        [Column(TypeName = "datetime2(0)")]
        public DateTime? FecEnt { get; set; }
    }
}
