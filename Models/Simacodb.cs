using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIMACODB")]
    public partial class Simacodb
    {
        [Required]
        [Column("CODIGOP")]
        [StringLength(10)]
        public string Codigop { get; set; }
        [Required]
        [Column("CODIGOB")]
        [StringLength(14)]
        public string Codigob { get; set; }
        [Column("LABORATORIO")]
        [StringLength(7)]
        public string Laboratorio { get; set; }
        [Column("DES_PORC")]
        public double? DesPorc { get; set; }
        [Column("DES_VALOR")]
        public double? DesValor { get; set; }
        [Column("FECEXP_DES", TypeName = "datetime2(0)")]
        public DateTime? FecexpDes { get; set; }
        [Column("INC_PORC")]
        public double? IncPorc { get; set; }
        [Column("INC_VALOR")]
        public double? IncValor { get; set; }
        [Column("FECEXP_INC", TypeName = "datetime2(0)")]
        public DateTime? FecexpInc { get; set; }
        [Column("PRECIO_VEN")]
        public double? PrecioVen { get; set; }
        [Column("FECEXP_PRE", TypeName = "datetime2(0)")]
        public DateTime? FecexpPre { get; set; }
        [Column("UN_INI")]
        public int? UnIni { get; set; }
        [Column("UN_FIN")]
        public int? UnFin { get; set; }
        [Column("COSTO_UC")]
        public double? CostoUc { get; set; }
        [Column("FECHA_UC", TypeName = "datetime2(0)")]
        public DateTime? FechaUc { get; set; }
        [Column("ORDEN_UC")]
        [StringLength(10)]
        public string OrdenUc { get; set; }
        public float? Largo { get; set; }
        public float? Ancho { get; set; }
        public float? Alto { get; set; }
        public float? Peso { get; set; }
        public bool? Bioequivalente { get; set; }
        public short? Principal { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
