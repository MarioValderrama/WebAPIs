using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("GETRANSP")]
    public partial class Getransp
    {
        [StringLength(10)]
        public string NumGuia { get; set; }
        public int? Local { get; set; }
        [StringLength(4)]
        public string Trans { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaT { get; set; }
        [StringLength(20)]
        public string Boleto { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaR { get; set; }
        [StringLength(12)]
        public string Rut { get; set; }
        [StringLength(40)]
        public string NomRec { get; set; }
        [StringLength(8)]
        public string Usuario { get; set; }
        [StringLength(10)]
        public string Factura { get; set; }
        public float? Peso { get; set; }
        public float? Volumen { get; set; }
        public int? Flete { get; set; }
        public int? Bultos { get; set; }
        [StringLength(4)]
        public string Transporte { get; set; }
        [StringLength(255)]
        public string Obs { get; set; }
        public bool? EnRuta { get; set; }
        [StringLength(1)]
        public string Entrega { get; set; }
        public int? ValorDe { get; set; }
        public short? Largo { get; set; }
        public short? Ancho { get; set; }
        public short? Alto { get; set; }
        [StringLength(40)]
        public string ObsT { get; set; }
        public short? Prioridad { get; set; }
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column("U_Bultos_RX")]
        public int? UBultosRx { get; set; }
        [Column("U_ID_Motivo")]
        public int? UIdMotivo { get; set; }
        [Column("U_Fecha_RI", TypeName = "datetime2(0)")]
        public DateTime? UFechaRi { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
