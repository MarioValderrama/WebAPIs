﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("INDSCENC")]
    public partial class Indscenc
    {
        [Key]
        [StringLength(10)]
        public string NumGuia { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("LOCAL")]
        public int? Local { get; set; }
        [Column("BODEGA")]
        [StringLength(4)]
        public string Bodega { get; set; }
        [Column("OBSERVACION")]
        [StringLength(100)]
        public string Observacion { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column("Guía_Desp")]
        [StringLength(10)]
        public string GuíaDesp { get; set; }
        [StringLength(8)]
        public string Usuario { get; set; }
        [StringLength(10)]
        public string NumFac { get; set; }
        [StringLength(10)]
        public string RutCli { get; set; }
        public int? Vendedor { get; set; }
        [StringLength(1)]
        public string EstVenta { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(1)]
        public string EstGuia { get; set; }
        [StringLength(1)]
        public string TipoGuía { get; set; }
    }
}
