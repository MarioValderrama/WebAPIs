using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VEVENENC")]
    public partial class Vevenenc
    {
        [Required]
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [Column("HORA")]
        [StringLength(8)]
        public string Hora { get; set; }
        [Required]
        [Column("CODBOD")]
        [StringLength(3)]
        public string Codbod { get; set; }
        [Column("LOCAL")]
        public int? Local { get; set; }
        [Column("CAJA")]
        [StringLength(4)]
        public string Caja { get; set; }
        [Column("VENDEDOR")]
        public int? Vendedor { get; set; }
        [Column("FORMAP")]
        [StringLength(4)]
        public string Formap { get; set; }
        [Column("DESCFP")]
        public double? Descfp { get; set; }
        [Column("PDes_cli")]
        public double? PdesCli { get; set; }
        [Column("PRec_cli")]
        public double? PrecCli { get; set; }
        [Column("NETO")]
        public double? Neto { get; set; }
        [Column("DESCUENTO")]
        public double? Descuento { get; set; }
        [Column("Des_cli")]
        public double? DesCli { get; set; }
        [Column("Rec_cli")]
        public double? RecCli { get; set; }
        [Column("TOTAL")]
        public double? Total { get; set; }
        [Column("Rut_Cliente")]
        [StringLength(10)]
        public string RutCliente { get; set; }
        [Column("USUARIO")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("IMPUESTO")]
        public double Impuesto { get; set; }
        [Column("ESTADO")]
        [StringLength(1)]
        public string Estado { get; set; }
        [Column("USUARIOA")]
        [StringLength(8)]
        public string Usuarioa { get; set; }
        [Column("FECHAA", TypeName = "datetime")]
        public DateTime? Fechaa { get; set; }
        [StringLength(10)]
        public string NumGui { get; set; }
        [StringLength(2)]
        public string Tipo { get; set; }
        [Column("IVA")]
        public double? Iva { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column("NCVal")]
        public double? Ncval { get; set; }
        [Column("NDVal")]
        public double? Ndval { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fechav { get; set; }
        public double? Subtotal { get; set; }
        public double? DescuentoAd { get; set; }
        [Column("DTE")]
        public short? Dte { get; set; }
        [Column("clave01")]
        [StringLength(12)]
        public string Clave01 { get; set; }
        public short? Vend2 { get; set; }
        [Column("Asigna_Tr")]
        [StringLength(1)]
        public string AsignaTr { get; set; }
        public int? Bultos { get; set; }
        [StringLength(1)]
        public string Saldada { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? MontoSaldo { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
