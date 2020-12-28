using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZzSysVentasPeríodo
    {
        [Required]
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [Column("VENDEDOR")]
        public int? Vendedor { get; set; }
        [Column("NETO")]
        public double? Neto { get; set; }
        [Column("TOTAL")]
        public double? Total { get; set; }
        [Column("Rut_Cliente")]
        [StringLength(10)]
        public string RutCliente { get; set; }
        [Column("ESTADO")]
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(2)]
        public string Tipo { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column("Asigna_Tr")]
        [StringLength(1)]
        public string AsignaTr { get; set; }
        [StringLength(4)]
        public string Zona { get; set; }
    }
}
