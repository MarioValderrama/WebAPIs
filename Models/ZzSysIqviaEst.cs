using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZzSysIqviaEst
    {
        [StringLength(4000)]
        public string Período { get; set; }
        [Column("CODIGO")]
        [StringLength(10)]
        public string Codigo { get; set; }
        [Column("PRODUCTO")]
        [StringLength(80)]
        public string Producto { get; set; }
        [Column("LABORATORIO")]
        [StringLength(35)]
        public string Laboratorio { get; set; }
        [Column("CBarra")]
        [StringLength(14)]
        public string Cbarra { get; set; }
        [StringLength(10)]
        public string Clave { get; set; }
        [StringLength(80)]
        public string Cliente { get; set; }
        [Column("DIRECCION")]
        [StringLength(50)]
        public string Direccion { get; set; }
        [StringLength(35)]
        public string Comuna { get; set; }
        [StringLength(35)]
        public string Ciudad { get; set; }
        [Required]
        [StringLength(6)]
        public string Tipo { get; set; }
        public float? Unidades { get; set; }
        public float? Venta { get; set; }
    }
}
