using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("LGPERSON")]
    public  class Lgperson
    {
        [Key]
        [Column("Cod_Per")]
        [StringLength(4)]
        public string CodPer { get; set; }
        [Column("Des_Per")]
        [StringLength(35)]
        public string DesPer { get; set; }
        [StringLength(1)]
        public string Prep { get; set; }
        [StringLength(1)]
        public string Rev { get; set; }
        [StringLength(1)]
        public string Trans { get; set; }
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("U_Pass")]
        [StringLength(50)]
        public string UPass { get; set; }
        [Column("U_ID_Mobile")]
        public int? UIdMobile { get; set; }
        public bool? Estado { get; set; }
        [StringLength(4)]
        public string Transporte { get; set; }
        //[Required]
        //[Column("SSMA_TimeStamp")]
        //public byte[] SsmaTimeStamp { get; set; }
    }
}
