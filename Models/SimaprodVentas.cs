using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class SimaprodVentas
    {
        [Column("a_Código")]
        [StringLength(10)]
        public string ACódigo { get; set; }
        [StringLength(80)]
        public string Descripción { get; set; }
        [StringLength(60)]
        public string Compras { get; set; }
        [StringLength(60)]
        public string Resumida { get; set; }
        [StringLength(1)]
        public string Est { get; set; }
        [Column("UM")]
        [StringLength(4)]
        public string Um { get; set; }
        [Column("Cód Clase")]
        [StringLength(4)]
        public string CódClase { get; set; }
        [StringLength(35)]
        public string Clase { get; set; }
        [Column("Cód Laboratorio")]
        [StringLength(7)]
        public string CódLaboratorio { get; set; }
        [StringLength(35)]
        public string Laboratorio { get; set; }
        [StringLength(1)]
        public string Controlado { get; set; }
        [Column("Precio Venta")]
        public double? PrecioVenta { get; set; }
        [Column("Costo Promedio")]
        public double? CostoPromedio { get; set; }
        [Column("Costo Ult Compra")]
        public double? CostoUltCompra { get; set; }
        [Column("Fecha Ult Compra", TypeName = "datetime")]
        public DateTime? FechaUltCompra { get; set; }
        [Column("Precio Referencia")]
        public double? PrecioReferencia { get; set; }
        [Column("Precio Portal")]
        public double? PrecioPortal { get; set; }
        [Column("Precio Oferta")]
        public double? PrecioOferta { get; set; }
        [Column("Fecha Exp Oferta", TypeName = "datetime")]
        public DateTime? FechaExpOferta { get; set; }
        public int? Cons1 { get; set; }
        public int? Cons2 { get; set; }
        public int? Cons3 { get; set; }
        public int? Cons4 { get; set; }
        public int? Cons5 { get; set; }
        public int? Cons6 { get; set; }
        [Column("Pendiente Recepción")]
        public int? PendienteRecepción { get; set; }
        public float? Peso { get; set; }
        [Column("Registro_ISP")]
        [StringLength(20)]
        public string RegistroIsp { get; set; }
        [Column("CodTCom")]
        [StringLength(4)]
        public string CodTcom { get; set; }
        [Column("Clasif_Comercial")]
        [StringLength(35)]
        public string ClasifComercial { get; set; }
        [Column("Pr_Activo")]
        [StringLength(4)]
        public string PrActivo { get; set; }
        [Column("Principio_Activo")]
        [StringLength(80)]
        public string PrincipioActivo { get; set; }
        [Column("Cl_Terap")]
        [StringLength(4)]
        public string ClTerap { get; set; }
        [Column("Clase_Terapéutica")]
        [StringLength(35)]
        public string ClaseTerapéutica { get; set; }
        public int? Empaque { get; set; }
        public int? Contiene { get; set; }
        [Column("Cód_FF")]
        [StringLength(4)]
        public string CódFf { get; set; }
        [Column("Forma_Farmacéutica")]
        [StringLength(35)]
        public string FormaFarmacéutica { get; set; }
        [Column("Código_Fr")]
        [StringLength(10)]
        public string CódigoFr { get; set; }
    }
}
