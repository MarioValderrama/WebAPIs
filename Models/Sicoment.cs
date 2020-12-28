using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SICOMENT")]
    public partial class Sicoment
    {
        [Required]
        [StringLength(4)]
        public string Módulo { get; set; }
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column(TypeName = "datetime2(0)")]
        public DateTime? Fecha { get; set; }
        [StringLength(140)]
        public string Comentario { get; set; }
        [StringLength(15)]
        public string Clave { get; set; }
    }
}
