using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("ININVLOT")]
    public partial class Ininvlot
    {
        [Column("CODBOD")]
        [StringLength(3)]
        public string Codbod { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("CODIGOB")]
        [StringLength(14)]
        public string Codigob { get; set; }
        [Column("NLOTE")]
        [StringLength(15)]
        public string Nlote { get; set; }
        [Column("FECHA_C", TypeName = "datetime")]
        public DateTime? FechaC { get; set; }
        [Column("FECHA_V", TypeName = "datetime")]
        public DateTime? FechaV { get; set; }
        [Column("POTENCIA")]
        public int? Potencia { get; set; }
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
        [Column("MARCA")]
        [StringLength(1)]
        public string Marca { get; set; }
        [Column("SF1")]
        public double? Sf1 { get; set; }
        [StringLength(50)]
        public string Observ { get; set; }
        public short? BioEq { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
