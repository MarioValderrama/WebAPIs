using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("INHSTINV")]
    public partial class Inhstinv
    {
        [Column("FECHAH", TypeName = "datetime")]
        public DateTime? Fechah { get; set; }
        [Column("CODBOD")]
        [StringLength(3)]
        public string Codbod { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(60)]
        public string Descripcion { get; set; }
        [Column("STOCK")]
        public double? Stock { get; set; }
        [Column("RESERVA")]
        public double? Reserva { get; set; }
        [Column("COSTO")]
        public double? Costo { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
