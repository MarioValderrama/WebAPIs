using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class Preparacion
    {
        [Column("SDDOCO")]
        [StringLength(50)]
        public string Sddoco { get; set; }
        [Column("SDAITM")]
        [StringLength(15)]
        public string Sdaitm { get; set; }
        [Column("SDVR01")]
        [StringLength(255)]
        public string Sdvr01 { get; set; }
        [Column("SDDSC2")]
        [StringLength(255)]
        public string Sddsc2 { get; set; }
        [Column("SDDSC1")]
        [StringLength(255)]
        public string Sddsc1 { get; set; }
        [StringLength(50)]
        public string Ncaja { get; set; }
        [StringLength(50)]
        public string Origen { get; set; }
        [StringLength(50)]
        public string Lote { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Cantidad { get; set; }
        [StringLength(50)]
        public string Npallet { get; set; }
        [StringLength(50)]
        public string TipoProd { get; set; }
        [Column("Tipo_Caja")]
        [StringLength(50)]
        public string TipoCaja { get; set; }
        [StringLength(50)]
        public string Dimensiones { get; set; }
        [Column(TypeName = "numeric(18, 3)")]
        public decimal? PesoCajaPicking { get; set; }
        [Column(TypeName = "numeric(18, 3)")]
        public decimal? PesoCajaEtiquetado { get; set; }
        [Column(TypeName = "numeric(18, 3)")]
        public decimal? PesoCajaRecpSellado { get; set; }
        [Column(TypeName = "numeric(18, 3)")]
        public decimal? PesoCajaSellado { get; set; }
        [Column(TypeName = "numeric(18, 3)")]
        public decimal? PesoCajaDespacho { get; set; }
        [StringLength(50)]
        public string UsuarioRecpEtiq { get; set; }
        [Column("fecharecetiq", TypeName = "datetime")]
        public DateTime? Fecharecetiq { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Horarecetiq { get; set; }
        [StringLength(50)]
        public string UsuarioEtiq { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaEtiq { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HoraEtiq { get; set; }
        [StringLength(50)]
        public string UsuarioRecpSellado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRecpSellado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HoraRecpSellado { get; set; }
        [StringLength(50)]
        public string UsuarioSellado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaSellado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HoraSellado { get; set; }
        [StringLength(50)]
        public string Usuariodespacho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaDespacho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Horadespacho { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [Column("obs")]
        [StringLength(50)]
        public string Obs { get; set; }
        [Column("fechaupdate", TypeName = "datetime")]
        public DateTime? Fechaupdate { get; set; }
        [Column("id", TypeName = "numeric(18, 0)")]
        public decimal Id { get; set; }
        [StringLength(50)]
        public string UsuarioEmbarque { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaEmbarque { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HoraEmbarque { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? CantVali { get; set; }
        [StringLength(50)]
        public string Ncaja1 { get; set; }
        [Column("SDDOC")]
        [StringLength(50)]
        public string Sddoc { get; set; }
        [Column("SDAN8")]
        [StringLength(10)]
        public string Sdan8 { get; set; }
        [Column("SKUCLIENTE")]
        [StringLength(50)]
        public string Skucliente { get; set; }
    }
}
