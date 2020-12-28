using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class VevenencVentaHistórica
    {
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("LOCAL")]
        public int? Local { get; set; }
        [Column("ESTADO")]
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(2)]
        public string Tipo { get; set; }
        [Column("Rut_Cliente")]
        [StringLength(10)]
        public string RutCliente { get; set; }
        [Column("DV")]
        [StringLength(1)]
        public string Dv { get; set; }
        [Column("IDENTIFICADOR")]
        [StringLength(80)]
        public string Identificador { get; set; }
        [StringLength(1)]
        public string Expr1 { get; set; }
        [StringLength(2)]
        public string Expr2 { get; set; }
        [StringLength(2)]
        public string Expr3 { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("QREAL")]
        public float? Qreal { get; set; }
        [Column("COSTOP")]
        public float? Costop { get; set; }
        [Column("PRECIO")]
        public float? Precio { get; set; }
        [Column("NETO")]
        public double? Neto { get; set; }
        [Column("DESCRI_RES")]
        [StringLength(60)]
        public string DescriRes { get; set; }
        [StringLength(7)]
        public string Labo { get; set; }
        [Column("DESCRI_LAB")]
        [StringLength(35)]
        public string DescriLab { get; set; }
        [StringLength(80)]
        public string Expr4 { get; set; }
        [Column("DesTVen")]
        [StringLength(35)]
        public string DesTven { get; set; }
        [StringLength(35)]
        public string DesCanal { get; set; }
        [StringLength(35)]
        public string DesZona { get; set; }
        [Column("DesTCli")]
        [StringLength(35)]
        public string DesTcli { get; set; }
        public float? PrOferta { get; set; }
        public float? PrReferencia { get; set; }
        public float? PrFinal { get; set; }
        [StringLength(20)]
        public string OrdC { get; set; }
        [StringLength(1)]
        public string Expr5 { get; set; }
    }
}
