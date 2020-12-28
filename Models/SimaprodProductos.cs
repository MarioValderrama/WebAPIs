using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class SimaprodProductos
    {
        [StringLength(10)]
        public string Código { get; set; }
        [StringLength(80)]
        public string Descripción { get; set; }
        [StringLength(60)]
        public string Compras { get; set; }
        [StringLength(60)]
        public string Resumida { get; set; }
        [StringLength(1)]
        public string Est { get; set; }
        [Column("UM")]
        [StringLength(4)]
        public string Um { get; set; }
        [Column("Cód Clase")]
        [StringLength(4)]
        public string CódClase { get; set; }
        [StringLength(35)]
        public string Clase { get; set; }
        [Column("Cód Laboratorio")]
        [StringLength(7)]
        public string CódLaboratorio { get; set; }
        [StringLength(35)]
        public string Laboratorio { get; set; }
    }
}
