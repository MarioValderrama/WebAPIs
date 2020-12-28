using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIRUTCON")]
    public partial class Sirutcon
    {
        [Column("RUTPRO")]
        [StringLength(10)]
        public string Rutpro { get; set; }
        [Column("DV")]
        [StringLength(1)]
        public string Dv { get; set; }
        [Column("DIRECCION")]
        [StringLength(50)]
        public string Direccion { get; set; }
        [Column("COMUNA")]
        [StringLength(4)]
        public string Comuna { get; set; }
        [Column("CIUDAD")]
        [StringLength(4)]
        public string Ciudad { get; set; }
        [Column("PAIS")]
        [StringLength(4)]
        public string Pais { get; set; }
        [Column("CELULAR")]
        [StringLength(30)]
        public string Celular { get; set; }
        [Column("FONO")]
        [StringLength(30)]
        public string Fono { get; set; }
        [Column("FAX")]
        [StringLength(15)]
        public string Fax { get; set; }
        [Column("EMAIL")]
        [StringLength(40)]
        public string Email { get; set; }
        [Column("AREA")]
        [StringLength(1)]
        public string Area { get; set; }
        [Column("OBS")]
        [StringLength(100)]
        public string Obs { get; set; }
        [Key]
        [Column("flag")]
        public int Flag { get; set; }
        [Required]
        [Column("RS_Nombre")]
        [StringLength(80)]
        public string RsNombre { get; set; }
    }
}
