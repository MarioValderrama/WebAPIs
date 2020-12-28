using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxNotadeVentasStatus2
    {
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Expr1 { get; set; }
        [StringLength(10)]
        public string RutCli { get; set; }
        [StringLength(10)]
        public string Folio { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        [Column("BODEGA")]
        [StringLength(4)]
        public string Bodega { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("Cant_Conf")]
        public double? CantConf { get; set; }
        [Column("Cant_Ped")]
        public double? CantPed { get; set; }
        [Column("Cant_Esc")]
        public double? CantEsc { get; set; }
        [Column("Cant_NV")]
        public double? CantNv { get; set; }
        [Column("IDENTIFICADOR")]
        [StringLength(80)]
        public string Identificador { get; set; }
        [StringLength(35)]
        public string DesCanal { get; set; }
        [Column("Hora Digitacion")]
        [StringLength(4000)]
        public string HoraDigitacion { get; set; }
        [Column("FPAGO")]
        [StringLength(4)]
        public string Fpago { get; set; }
        public short? Retenido { get; set; }
        [StringLength(35)]
        public string Motivo { get; set; }
        public int? TotalItem { get; set; }
        public int? Vend { get; set; }
        [Column("vendedor")]
        [StringLength(80)]
        public string Vendedor { get; set; }
        [StringLength(4)]
        public string Zona { get; set; }
        [Column("Hora de Preparacion")]
        [StringLength(4000)]
        public string HoraDePreparacion { get; set; }
        [StringLength(20)]
        public string Boleto { get; set; }
        [StringLength(4)]
        public string Transporte { get; set; }
        [StringLength(35)]
        public string DesTrans { get; set; }
        [Column("Fecha Trasporte", TypeName = "datetime")]
        public DateTime? FechaTrasporte { get; set; }
    }
}
