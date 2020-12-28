using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("IEDETBKP")]
    public partial class Iedetbkp
    {
        [Required]
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("FECHA", TypeName = "datetime2(0)")]
        public DateTime? Fecha { get; set; }
        [Column("CODBOD")]
        [StringLength(3)]
        public string Codbod { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("CODIGOB")]
        [StringLength(14)]
        public string Codigob { get; set; }
        [Column("TOTTEO")]
        public double? Totteo { get; set; }
        [Column("TOTREC")]
        public double? Totrec { get; set; }
        [Column("CODUNI")]
        [StringLength(4)]
        public string Coduni { get; set; }
        [Column("CODUNIR")]
        [StringLength(4)]
        public string Codunir { get; set; }
        [Column("FACTORC")]
        public double? Factorc { get; set; }
        [Column("LOTE")]
        [StringLength(15)]
        public string Lote { get; set; }
        [Column("FECHA_VEN", TypeName = "datetime2(0)")]
        public DateTime? FechaVen { get; set; }
        [Column("POTENCIA")]
        public double? Potencia { get; set; }
        [Column("PRECUNI")]
        public double? Precuni { get; set; }
        [Column("VALTOT")]
        public double? Valtot { get; set; }
        [Column("UBICA")]
        [StringLength(14)]
        public string Ubica { get; set; }
        [Column("ORDC")]
        [StringLength(10)]
        public string Ordc { get; set; }
        [Column("FECHAENT", TypeName = "datetime2(0)")]
        public DateTime? Fechaent { get; set; }
        [Column("NUMLIN")]
        public double? Numlin { get; set; }
        [Column("ESTADO")]
        [StringLength(1)]
        public string Estado { get; set; }
        [Column("USUARIO")]
        [StringLength(8)]
        public string Usuario { get; set; }
        public double? Descp { get; set; }
        public double? Pref { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
