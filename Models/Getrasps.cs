using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("GETRASPS")]
    public partial class Getrasps
    {
        [Column("FECHA_PRO", TypeName = "datetime2(0)")]
        public DateTime? FechaPro { get; set; }
        [Column("LOCAL")]
        [StringLength(3)]
        public string Local { get; set; }
        [Column("CODCUENTA")]
        [StringLength(10)]
        public string Codcuenta { get; set; }
        [Column("NOMBRECTA")]
        [StringLength(35)]
        public string Nombrecta { get; set; }
        [Column("CC")]
        [StringLength(7)]
        public string Cc { get; set; }
        [Column("DEBE")]
        public double? Debe { get; set; }
        [Column("HABER")]
        public double? Haber { get; set; }
        [Column("RUT")]
        [StringLength(12)]
        public string Rut { get; set; }
        [Column("TIPOD")]
        [StringLength(2)]
        public string Tipod { get; set; }
        [Column("DOCUMENTO")]
        [StringLength(10)]
        public string Documento { get; set; }
        [Column("GLOSA")]
        [StringLength(60)]
        public string Glosa { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
