using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("INHSTLOT")]
    public partial class Inhstlot
    {
        [Column("FECHAH", TypeName = "datetime")]
        public DateTime? Fechah { get; set; }
        [Column("CODBOD")]
        [StringLength(3)]
        public string Codbod { get; set; }
        [Required]
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("NLOTE")]
        [StringLength(15)]
        public string Nlote { get; set; }
        [Column("FECHA_C", TypeName = "datetime")]
        public DateTime? FechaC { get; set; }
        [Column("FECHA_V", TypeName = "datetime")]
        public DateTime? FechaV { get; set; }
        [Column("STOCK")]
        public double? Stock { get; set; }
        [Column("RESERVA")]
        public double? Reserva { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
