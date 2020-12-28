using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class PedidosAsignados
    {
        [Key]
        [Column("Cod_Per")]
        [StringLength(4)]
        public string CodPer { get; set; }
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        public double? Total { get; set; }
        public int? Líneas { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
       
        [StringLength(10)]
        public string NumPed { get; set; }
        [StringLength(2)]
        public string Area { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("Des_Per")]
        [StringLength(35)]
        public string DesPer { get; set; }
        [Column("BODEGA")]
        [StringLength(4)]
        public string Bodega { get; set; }
        [Column("FAsign", TypeName = "datetime")]
        public DateTime? Fasign { get; set; }
      //  public Lgperson Lgperson { get; set; }
    }
}
