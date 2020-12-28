using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class PedidosPreparacion
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
        [Column("cantidad", TypeName = "numeric(38, 0)")]
        public decimal? Cantidad { get; set; }
        [Column(TypeName = "decimal(38, 0)")]
        public decimal? CantVali { get; set; }
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("Cant_Esc")]
        public double? CantEsc { get; set; }
        [Column("BODEGA")]
        [StringLength(4)]
        public string Bodega { get; set; }
    }
}
