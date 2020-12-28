using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxVenta
    {
        [Column("Nº  Documento")]
        [StringLength(10)]
        public string NºDocumento { get; set; }
        [Column("Fecha Documento", TypeName = "datetime")]
        public DateTime? FechaDocumento { get; set; }
        public double? Neto { get; set; }
        public double? Bruto { get; set; }
        public double? Iva { get; set; }
        [Column("Nº  Nota de Venta")]
        [StringLength(10)]
        public string NºNotaDeVenta { get; set; }
        [Column("Nº Guia")]
        [StringLength(10)]
        public string NºGuia { get; set; }
        [StringLength(2)]
        public string Tipo { get; set; }
        [StringLength(35)]
        public string DesCanal { get; set; }
        [Column("ID-Bodega")]
        [StringLength(3)]
        public string IdBodega { get; set; }
        [StringLength(35)]
        public string Bodega { get; set; }
        [StringLength(80)]
        public string Cliente { get; set; }
        [Column("ID-Vendedor")]
        public int? IdVendedor { get; set; }
        [StringLength(4)]
        public string Zona { get; set; }
        [StringLength(4)]
        public string Canal { get; set; }
        public int? Vend { get; set; }
        [StringLength(35)]
        public string Comuna { get; set; }
        [StringLength(35)]
        public string Ciudad { get; set; }
        [StringLength(80)]
        public string Vendedor { get; set; }
    }
}
