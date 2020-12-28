using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("VEPEDENC")]
    public partial class Vepedenc
    {
        [Key]
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FecPed { get; set; }
        [StringLength(10)]
        public string RutCli { get; set; }
        [Column("FPago")]
        [StringLength(4)]
        public string Fpago { get; set; }
        [StringLength(1)]
        public string AfEx { get; set; }
        [StringLength(4)]
        public string CodMon { get; set; }
        [StringLength(100)]
        public string Observ { get; set; }
        [StringLength(1)]
        public string Estado { get; set; }
        [StringLength(8)]
        public string Usuario { get; set; }
        public double? Iva { get; set; }
        public int? Local { get; set; }
        [StringLength(4)]
        public string TipVen { get; set; }
        [StringLength(4)]
        public string Canal { get; set; }
        [StringLength(4)]
        public string Zona { get; set; }
        [StringLength(4)]
        public string TipCli { get; set; }
        [StringLength(4)]
        public string LisPre { get; set; }
        [StringLength(10)]
        public string NumCot { get; set; }
        public int? Vend { get; set; }
        [StringLength(20)]
        public string OrdC { get; set; }
        public int? Direcc { get; set; }
        [StringLength(1)]
        public string Interno { get; set; }
        public int? Flete { get; set; }
        public int? Unidades { get; set; }
        [StringLength(3)]
        public string Bodega { get; set; }
        public short? FacturarA { get; set; }
        [StringLength(1)]
        public string NoFact { get; set; }
        [StringLength(50)]
        public string FolCon { get; set; }
        [Column(TypeName = "datetime2(0)")]
        public DateTime? FecEnt { get; set; }
        public short? Parcial { get; set; }
        public short? Retenido { get; set; }
        [StringLength(100)]
        public string ObsGuía { get; set; }
        [Column("IDLic")]
        [StringLength(25)]
        public string Idlic { get; set; }
        public short? EsMuestra { get; set; }
        public short? RetCom { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
