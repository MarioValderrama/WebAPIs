using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxItemsFacturados
    {
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("CODMP")]
        [StringLength(10)]
        public string Codmp { get; set; }
        [Column("LOTE")]
        [StringLength(15)]
        public string Lote { get; set; }
        [Column("UBICACION")]
        [StringLength(14)]
        public string Ubicacion { get; set; }
        [Column("PRECIO")]
        public float? Precio { get; set; }
        [StringLength(10)]
        public string NumGui { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
        [StringLength(10)]
        public string RutCli { get; set; }
        [StringLength(80)]
        public string Cliente { get; set; }
        [StringLength(35)]
        public string Canal { get; set; }
        [Column("Canal Global")]
        [StringLength(35)]
        public string CanalGlobal { get; set; }
        [StringLength(4)]
        public string Zona { get; set; }
        [Column("Fecha_factura", TypeName = "datetime")]
        public DateTime? FechaFactura { get; set; }
        [Column("QREAL")]
        public float? Qreal { get; set; }
        [StringLength(2)]
        public string Tipo { get; set; }
        [StringLength(80)]
        public string Vendedor { get; set; }
        [Column("DESCRI_COM")]
        [StringLength(60)]
        public string DescriCom { get; set; }
        [Column("DESCRI_LAB")]
        [StringLength(35)]
        public string DescriLab { get; set; }
        [Column("COSTOP")]
        public float? Costop { get; set; }
        [StringLength(8)]
        public string Usuario { get; set; }
    }
}
