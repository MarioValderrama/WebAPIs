using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("COPAGOCO")]
    public partial class Copagoco
    {
        [StringLength(100)]
        public string Empresa { get; set; }
        public int? Vendedor { get; set; }
        [StringLength(80)]
        public string NomVend { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Key]
        [StringLength(10)]
        public string Factura { get; set; }
        [StringLength(12)]
        public string Rut { get; set; }
        [Column("RS")]
        [StringLength(150)]
        public string Rs { get; set; }
        [Column("OC")]
        [StringLength(30)]
        public string Oc { get; set; }
        public long? Total { get; set; }
        [Column("NC")]
        public long? Nc { get; set; }
        [Column("ND")]
        public long? Nd { get; set; }
        [Column("Abono_PA")]
        public long? AbonoPa { get; set; }
        [Column("CHEQUE_A_FECHA")]
        public long? ChequeAFecha { get; set; }
        public long? Pagos { get; set; }
        public long? Saldo { get; set; }
        [Column("CONTRIBUCION")]
        public long? Contribucion { get; set; }
        public float? Factor { get; set; }
        [Column("COMISION")]
        public long? Comision { get; set; }
        [Column("Factor_Sup")]
        public float? FactorSup { get; set; }
        [Column("COMISION_SUP")]
        public long? ComisionSup { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
