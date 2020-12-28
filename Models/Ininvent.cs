using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("ININVENT")]
    public partial class Ininvent
    {
        [Column("CODBOD")]
        [StringLength(3)]
        public string Codbod { get; set; }
        [Column("CODIGOB")]
        [StringLength(13)]
        public string Codigob { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("STOCK")]
        public double? Stock { get; set; }
        [Column("RESERVA")]
        public double? Reserva { get; set; }
        [Column("CODUNI")]
        [StringLength(4)]
        public string Coduni { get; set; }
        [Column("ST0")]
        public double? St0 { get; set; }
        [Column("SF0")]
        public double? Sf0 { get; set; }
        [Column("PREC0")]
        public double? Prec0 { get; set; }
        [Column("MARCA")]
        public string Marca { get; set; }
        public double? Pedido { get; set; }
        [Column("SF1")]
        public double? Sf1 { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
