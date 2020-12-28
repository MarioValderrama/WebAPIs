using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VEMVENTA")]
    public partial class Vemventa
    {
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("CODIGOB")]
        [StringLength(14)]
        public string Codigob { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("QREAL")]
        public float? Qreal { get; set; }
        [Column("CODUNI")]
        [StringLength(4)]
        public string Coduni { get; set; }
        [Column("CODUNIR")]
        [StringLength(4)]
        public string Codunir { get; set; }
        [Column("FACTORV")]
        public float? Factorv { get; set; }
        [Column("LOTE")]
        [StringLength(15)]
        public string Lote { get; set; }
        [Column("UBICACION")]
        [StringLength(14)]
        public string Ubicacion { get; set; }
        [Column("PRECIO")]
        public float? Precio { get; set; }
        [Column("PORCD")]
        public float? Porcd { get; set; }
        [Column("VALORD")]
        public float? Valord { get; set; }
        [Column("INCP")]
        public float? Incp { get; set; }
        [Column("VALORI")]
        public float? Valori { get; set; }
        [Column("COSTOP")]
        public float? Costop { get; set; }
        public float? PrFinal { get; set; }
        [Column("NC")]
        public float? Nc { get; set; }
        [Column("ND")]
        public float? Nd { get; set; }
        [StringLength(2)]
        public string Tipo { get; set; }
        [StringLength(10)]
        public string NumGui { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
        public float? PrReferencia { get; set; }
        public float? PrOferta { get; set; }
        [Column("clave01")]
        [StringLength(12)]
        public string Clave01 { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
