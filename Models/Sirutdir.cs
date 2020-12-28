using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIRUTDIR")]
    public partial class Sirutdir
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
        [Column("FONO")]
        [StringLength(30)]
        public string Fono { get; set; }
        [Column("FAX")]
        [StringLength(15)]
        public string Fax { get; set; }
        [Column("CONTACTO")]
        [StringLength(50)]
        public string Contacto { get; set; }
        [Column("EMAIL")]
        [StringLength(40)]
        public string Email { get; set; }
        [Column("OBS")]
        [StringLength(100)]
        public string Obs { get; set; }
        [Key]
        [Column("flag")]
        public int Flag { get; set; }
        [Column("U_Latitud")]
        [StringLength(15)]
        public string ULatitud { get; set; }
        [Column("U_Longitud")]
        [StringLength(15)]
        public string ULongitud { get; set; }
        [Column("U_DIRECCION_FULL")]
        [StringLength(50)]
        public string UDireccionFull { get; set; }
    }
}
