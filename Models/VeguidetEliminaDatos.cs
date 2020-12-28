using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class VeguidetEliminaDatos
    {
        [StringLength(50)]
        public string NumGuia { get; set; }
        [Column("local", TypeName = "numeric(18, 0)")]
        public decimal? Local { get; set; }
        [Column("CODIGOB")]
        [StringLength(14)]
        public string Codigob { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("CANTIDAD", TypeName = "numeric(18, 0)")]
        public decimal? Cantidad { get; set; }
        [Column("CODUNI")]
        [StringLength(50)]
        public string Coduni { get; set; }
        [Column("CODUNIR")]
        [StringLength(50)]
        public string Codunir { get; set; }
        [Column("FACTORV", TypeName = "numeric(18, 0)")]
        public decimal? Factorv { get; set; }
        [Column("LOTE")]
        [StringLength(50)]
        public string Lote { get; set; }
        [Column("UBICACION")]
        [StringLength(50)]
        public string Ubicacion { get; set; }
        [Column("VENCE", TypeName = "datetime")]
        public DateTime? Vence { get; set; }
        [Column("MOTIVO")]
        [StringLength(50)]
        public string Motivo { get; set; }
        [Column("OBSERVACION")]
        [StringLength(50)]
        public string Observacion { get; set; }
        [Column("Cant_Fact", TypeName = "decimal(18, 0)")]
        public decimal? CantFact { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Costop { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? LinPed { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? PrecioP { get; set; }
        [Column("NC", TypeName = "decimal(18, 0)")]
        public decimal? Nc { get; set; }
        [StringLength(50)]
        public string EsNc { get; set; }
        [StringLength(50)]
        public string EstGuia { get; set; }
        [StringLength(10)]
        public string Expr1 { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        public int? Expr2 { get; set; }
        [Column("BODEGA")]
        [StringLength(4)]
        public string Bodega { get; set; }
        [StringLength(100)]
        public string Expr3 { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
        [StringLength(10)]
        public string NumPrep { get; set; }
        [StringLength(8)]
        public string Usuario { get; set; }
        [StringLength(10)]
        public string NumFac { get; set; }
        [StringLength(10)]
        public string RutCli { get; set; }
        [StringLength(65)]
        public string Despacho { get; set; }
        public int? Vendedor { get; set; }
        [StringLength(1)]
        public string EstVenta { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(1)]
        public string Expr4 { get; set; }
        [StringLength(1)]
        public string TipoGuía { get; set; }
        public short? FacturarA { get; set; }
        [Column("DTE")]
        public short? Dte { get; set; }
        public short? DespacharA { get; set; }
    }
}
