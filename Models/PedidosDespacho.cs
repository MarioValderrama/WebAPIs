using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class PedidosDespacho
    {
        public double? Total { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column("TFolio")]
        public int? Tfolio { get; set; }
        [StringLength(4)]
        public string TipoCli { get; set; }
        [Column("DesTCli")]
        [StringLength(35)]
        public string DesTcli { get; set; }
        [Column("IDENTIFICADOR")]
        [StringLength(80)]
        public string Identificador { get; set; }
        [Column(TypeName = "datetime2(0)")]
        public DateTime? FecEnt { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
    }
}
