using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class SimaprodPrecioRef0YPrecioVen0
    {
        [Column("CODIGO_MAT")]
        [StringLength(10)]
        public string CodigoMat { get; set; }
        [Column("DESCRI_MAT")]
        [StringLength(80)]
        public string DescriMat { get; set; }
        [Column("DESCRI_COM")]
        [StringLength(60)]
        public string DescriCom { get; set; }
        [Column("DESCRI_RES")]
        [StringLength(60)]
        public string DescriRes { get; set; }
        [Column("ESTADO")]
        [StringLength(1)]
        public string Estado { get; set; }
        [Column("FECHA_D", TypeName = "datetime")]
        public DateTime? FechaD { get; set; }
        [Column("FECHA_C", TypeName = "datetime")]
        public DateTime? FechaC { get; set; }
        [Column("UNIMED_MAT")]
        [StringLength(4)]
        public string UnimedMat { get; set; }
        [Column("CLASE")]
        [StringLength(4)]
        public string Clase { get; set; }
        [Column("SUBCLASE")]
        [StringLength(4)]
        public string Subclase { get; set; }
        [Column("CODBARRA")]
        [StringLength(1)]
        public string Codbarra { get; set; }
        [Column("CLASIFICACION")]
        [StringLength(1)]
        public string Clasificacion { get; set; }
        [Column("FORFAR")]
        [StringLength(4)]
        public string Forfar { get; set; }
        [Column("PRACTIVO")]
        [StringLength(1)]
        public string Practivo { get; set; }
        [Column("CONTROLADO")]
        [StringLength(1)]
        public string Controlado { get; set; }
        [Column("PRECIO_VEN")]
        public double? PrecioVen { get; set; }
        [Column("PRECIO_VEN_ANT")]
        public double? PrecioVenAnt { get; set; }
        [Column("COSTO_PROM")]
        public double? CostoProm { get; set; }
        [Column("COSTOP_ANT")]
        public double? CostopAnt { get; set; }
        [Column("COSTO_UC")]
        public double? CostoUc { get; set; }
        [Column("FECHA_UC", TypeName = "datetime")]
        public DateTime? FechaUc { get; set; }
        [Column("ORDEN_UC")]
        [StringLength(10)]
        public string OrdenUc { get; set; }
        [Column("COSTO_UC1")]
        public double? CostoUc1 { get; set; }
        [Column("FECHA_UC1", TypeName = "datetime")]
        public DateTime? FechaUc1 { get; set; }
        [Column("ORDEN_UC1")]
        [StringLength(10)]
        public string OrdenUc1 { get; set; }
        [Column("DES_VALOR")]
        public double? DesValor { get; set; }
        [Column("DES_PORC", TypeName = "decimal(6, 2)")]
        public decimal? DesPorc { get; set; }
        [Column("INC_VALOR")]
        public double? IncValor { get; set; }
        [Column("INC_PORC", TypeName = "decimal(6, 2)")]
        public decimal? IncPorc { get; set; }
        [Column("VENTAP")]
        public int? Ventap { get; set; }
        [Column("STKMIN_MAT")]
        public int? StkminMat { get; set; }
        [Column("STKREP_MAT")]
        public int? StkrepMat { get; set; }
        [Column("STKMAX_MAT")]
        public int? StkmaxMat { get; set; }
        [Column("TIEMPOR")]
        public double? Tiempor { get; set; }
        [Column("LOTEC")]
        public double? Lotec { get; set; }
        [Column("INDICE")]
        [StringLength(10)]
        public string Indice { get; set; }
        [Column("REVISAR")]
        [StringLength(1)]
        public string Revisar { get; set; }
        [Column("PRECIO_REF")]
        public double? PrecioRef { get; set; }
        [Column("Um_com")]
        [StringLength(4)]
        public string UmCom { get; set; }
        [Column("Um_prod")]
        [StringLength(4)]
        public string UmProd { get; set; }
        [StringLength(7)]
        public string Labo { get; set; }
        [Column("Id_Prov")]
        public int? IdProv { get; set; }
        public double? PrPortal { get; set; }
        public float? Peso { get; set; }
        public int? Cons1 { get; set; }
        public int? Cons2 { get; set; }
        public int? Cons3 { get; set; }
        public int? Cons4 { get; set; }
        public int? Cons5 { get; set; }
        public int? Cons6 { get; set; }
        public int? PendRec { get; set; }
        public double? PrOferta { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FeOferta { get; set; }
        public int? Contiene { get; set; }
        [StringLength(1)]
        public string Refrigerado { get; set; }
        public int? Empaque { get; set; }
        [StringLength(1)]
        public string Supervisado { get; set; }
        [StringLength(15)]
        public string CdgProv { get; set; }
        [StringLength(1)]
        public string Clasif { get; set; }
        [Column("Registro_ISP")]
        [StringLength(20)]
        public string RegistroIsp { get; set; }
        [Column("CodTCom")]
        [StringLength(4)]
        public string CodTcom { get; set; }
        [Column("Pr_Activo")]
        [StringLength(4)]
        public string PrActivo1 { get; set; }
        [Column("Cl_Terap")]
        [StringLength(4)]
        public string ClTerap { get; set; }
        [Column("Cod_Fran")]
        [StringLength(10)]
        public string CodFran { get; set; }
        [Column("Bod_Prim")]
        [StringLength(3)]
        public string BodPrim { get; set; }
        public float? VolumenP { get; set; }
    }
}
