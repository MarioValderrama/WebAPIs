using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VEMLOCAL")]
    public partial class Vemlocal
    {
        [Column("Loc_Cod")]
        public int? LocCod { get; set; }
        [Column("Loc_Nom")]
        [StringLength(50)]
        public string LocNom { get; set; }
        [Column("DIREC")]
        [StringLength(50)]
        public string Direc { get; set; }
        [Column("COMUNA")]
        [StringLength(4)]
        public string Comuna { get; set; }
        [Column("CIUDAD")]
        [StringLength(4)]
        public string Ciudad { get; set; }
        [Column("PAIS")]
        [StringLength(4)]
        public string Pais { get; set; }
        [Column("FONO1")]
        [StringLength(30)]
        public string Fono1 { get; set; }
        [Column("FONO2")]
        [StringLength(30)]
        public string Fono2 { get; set; }
        [Column("FAX1")]
        [StringLength(15)]
        public string Fax1 { get; set; }
        [Column("FAX2")]
        [StringLength(15)]
        public string Fax2 { get; set; }
        [Column("CONTACTO")]
        [StringLength(50)]
        public string Contacto { get; set; }
        [Column("EMAIL")]
        [StringLength(40)]
        public string Email { get; set; }
        [Column("OBS")]
        [StringLength(100)]
        public string Obs { get; set; }
    }
}
