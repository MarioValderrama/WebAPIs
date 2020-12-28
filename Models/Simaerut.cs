using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIMAERUT")]
    public partial class Simaerut
    {
        [Key]
        [Column("RUTPRO")]
        [StringLength(10)]
        public string Rutpro { get; set; }
        [Column("DV")]
        [StringLength(1)]
        public string Dv { get; set; }
        [Column("ESTADO")]
        [StringLength(1)]
        public string Estado { get; set; }
        [Column("TIPO")]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Column("IDENTIFICADOR")]
        [StringLength(80)]
        public string Identificador { get; set; }
        [Column("APELLIDOS")]
        [StringLength(50)]
        public string Apellidos { get; set; }
        [Column("FECHA_C", TypeName = "datetime")]
        public DateTime? FechaC { get; set; }
        [Column("FECHA_B", TypeName = "datetime")]
        public DateTime? FechaB { get; set; }
        [Column("DIREC")]
        [StringLength(50)]
        public string Direc { get; set; }
        [Column("DIRECALT")]
        [StringLength(50)]
        public string Direcalt { get; set; }
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
        [StringLength(50)]
        public string Email { get; set; }
        [Column("SITIOW")]
        [StringLength(40)]
        public string Sitiow { get; set; }
        [Column("OBS")]
        [StringLength(100)]
        public string Obs { get; set; }
        [Column("GIRO")]
        [StringLength(4)]
        public string Giro { get; set; }
        [Column("FPAGO")]
        [StringLength(4)]
        public string Fpago { get; set; }
        [Column("VENDEDOR")]
        [StringLength(1)]
        public string Vendedor { get; set; }
        [Column("CMON")]
        [StringLength(4)]
        public string Cmon { get; set; }
        [Column("CODIGOI")]
        public int? Codigoi { get; set; }
        public double? Descuento { get; set; }
        public double? Recargo { get; set; }
        [StringLength(4)]
        public string TipoCli { get; set; }
        [StringLength(4)]
        public string Zona { get; set; }
        [StringLength(4)]
        public string Canal { get; set; }
        [StringLength(4)]
        public string TipVen { get; set; }
        [StringLength(4)]
        public string ListaP { get; set; }
        public int? Vend { get; set; }
        [StringLength(1)]
        public string Clasif { get; set; }
        [StringLength(50)]
        public string Contacto2 { get; set; }
        [StringLength(50)]
        public string Email2 { get; set; }
        public short? Envío { get; set; }
        public short? Resol { get; set; }
        public int? DíasCanje { get; set; }
        public int? Cupo { get; set; }
        [Column("COD_COB")]
        [StringLength(4)]
        public string CodCob { get; set; }
        [Column("GInt")]
        public short? Gint { get; set; }
        [Column("GDes")]
        public short? Gdes { get; set; }
        [Column("FRes")]
        public short? Fres { get; set; }
        [Column("FDet")]
        public short? Fdet { get; set; }
        public bool? EsRetail { get; set; }
        public bool? EsCenAbast { get; set; }
        [StringLength(1)]
        public string TipoRut { get; set; }
        [Column("U_Latitud")]
        [StringLength(15)]
        public string ULatitud { get; set; }
        [Column("U_Longitud")]
        [StringLength(15)]
        public string ULongitud { get; set; }
        [Column("U_DIRECCION_FULL")]
        [StringLength(50)]
        public string UDireccionFull { get; set; }
        [Column("CodTRans")]
        [StringLength(4)]
        public string CodTrans { get; set; }
        public short? Vend2 { get; set; }
        [Column("Clasif_Cr")]
        [StringLength(2)]
        public string ClasifCr { get; set; }
        [Column("Horario_Despacho")]
        [StringLength(150)]
        public string HorarioDespacho { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
