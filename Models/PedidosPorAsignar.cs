using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class PedidosPorAsignar
    {
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        public double? Unidades { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column("ESTADO")]
        [StringLength(1)]
        public string Estado { get; set; }
        [Column("TIPO")]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Column("IDENTIFICADOR")]
        [StringLength(80)]
        public string Identificador { get; set; }
        [Column("APELLIDOS")]
        [StringLength(50)]
        public string Apellidos { get; set; }
        [Column("DIREC")]
        [StringLength(50)]
        public string Direc { get; set; }
        public int? Lineas { get; set; }
        [Column("BODEGA")]
        [StringLength(4)]
        public string Bodega { get; set; }
        public short? Retenido { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [StringLength(4)]
        public string TipoCli { get; set; }
        [Column("DesTCli")]
        [StringLength(35)]
        public string DesTcli { get; set; }
        [StringLength(1)]
        public string Interno { get; set; }
    }
}
