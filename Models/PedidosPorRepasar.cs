using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class PedidosPorRepasar
    {
        [StringLength(10)]
        public string Código { get; set; }
        [StringLength(60)]
        public string Producto { get; set; }
        [Column("Cód_Labo")]
        [StringLength(7)]
        public string CódLabo { get; set; }
        [StringLength(35)]
        public string Laboratorio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("Nota_Pedido")]
        [StringLength(10)]
        public string NotaPedido { get; set; }
        [StringLength(1)]
        public string Est { get; set; }
        [StringLength(80)]
        public string Cliente { get; set; }
        [Column("Cód_Vend")]
        public int? CódVend { get; set; }
        [StringLength(131)]
        public string Vendedor { get; set; }
        public float? Pedido { get; set; }
        public double? Despachado { get; set; }
        public double? Facturado { get; set; }
        [Column("Nota_de_Crédito")]
        public int? NotaDeCrédito { get; set; }
        [Column("Stock_Disponible")]
        public double? StockDisponible { get; set; }
        [Column("Pendiente_Despacho")]
        public float? PendienteDespacho { get; set; }
        [Column("Pendiente_Recepción")]
        public int? PendienteRecepción { get; set; }
        [Column("Venta_p1")]
        public int? VentaP1 { get; set; }
        [Column("Venta_p2")]
        public int? VentaP2 { get; set; }
        [Column("Venta_p3")]
        public int? VentaP3 { get; set; }
        [Column("Venta_p4")]
        public int? VentaP4 { get; set; }
        [Column("Venta_p5")]
        public int? VentaP5 { get; set; }
        [Column("Venta_p6")]
        public int? VentaP6 { get; set; }
        [Column("Precio_Venta")]
        public double? PrecioVenta { get; set; }
        [Column("Precio_Costo")]
        public double? PrecioCosto { get; set; }
        [Column("Valorizado_Pend_Despacho")]
        public double? ValorizadoPendDespacho { get; set; }
        [Column("Contribución_Pend_Desp")]
        public double? ContribuciónPendDesp { get; set; }
        [Column("Flete_Nota_de_Venta")]
        public int? FleteNotaDeVenta { get; set; }
        [Column("UNidades_Nota_de_Venta")]
        public int? UnidadesNotaDeVenta { get; set; }
        [Column("DesTCli")]
        [StringLength(35)]
        public string DesTcli { get; set; }
        [Column("ESTADO")]
        [StringLength(1)]
        public string Estado { get; set; }
    }
}
