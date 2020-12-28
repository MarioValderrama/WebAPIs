using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("z_Informe_Ventas")]
    public partial class ZInformeVentas
    {
        public short? Vendedor { get; set; }
        [StringLength(10)]
        public string Código { get; set; }
        [StringLength(100)]
        public string Descripción { get; set; }
        public int? Unidades { get; set; }
        public int? Venta { get; set; }
        public int? Contribución { get; set; }
        public float? Margen { get; set; }
        [Column("Meta_Venta")]
        public int? MetaVenta { get; set; }
        [Column("Meta_Días")]
        public int? MetaDías { get; set; }
        public float? Cumplimiento { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
