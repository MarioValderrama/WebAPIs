using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPIs.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<User> User { get; set; } // modelo de User
        public virtual DbSet<Cmetaslp> Cmetaslp { get; set; }
        public virtual DbSet<Coarchfo> Coarchfo { get; set; }
        public virtual DbSet<Cobancos> Cobancos { get; set; }
        public virtual DbSet<Cofactor> Cofactor { get; set; }
        public virtual DbSet<Commetas> Commetas { get; set; }
        public virtual DbSet<Compagos> Compagos { get; set; }
        public virtual DbSet<CompagosRespaldo> CompagosRespaldo { get; set; }
        public virtual DbSet<Copagoco> Copagoco { get; set; }
        public virtual DbSet<Copagotr> Copagotr { get; set; }
        public virtual DbSet<Copagtbk> Copagtbk { get; set; }
        public virtual DbSet<Corespag> Corespag { get; set; }
        public virtual DbSet<Cotipdoc> Cotipdoc { get; set; }
        public virtual DbSet<DboCmetaslp> DboCmetaslp { get; set; }
        public virtual DbSet<EresumenNotadeVenta> EresumenNotadeVenta { get; set; }
        public virtual DbSet<ErroresAlGuardarAutocorrecciónDeNombres> ErroresAlGuardarAutocorrecciónDeNombres { get; set; }
        public virtual DbSet<ErroresDePegado> ErroresDePegado { get; set; }
        public virtual DbSet<FletesZonas> FletesZonas { get; set; }
        public virtual DbSet<Geocmdet> Geocmdet { get; set; }
        public virtual DbSet<Geocmenc> Geocmenc { get; set; }
        public virtual DbSet<Getransp> Getransp { get; set; }
        public virtual DbSet<GetranspCargaDatosTransportes> GetranspCargaDatosTransportes { get; set; }
        public virtual DbSet<GetranspTransporteMóvil> GetranspTransporteMóvil { get; set; }
        public virtual DbSet<GetranspTransportes> GetranspTransportes { get; set; }
        public virtual DbSet<Getrasps> Getrasps { get; set; }
        public virtual DbSet<GroupDespacho> GroupDespacho { get; set; }
        public virtual DbSet<GroupFacturado> GroupFacturado { get; set; }
        public virtual DbSet<GroupPicking> GroupPicking { get; set; }
        public virtual DbSet<GroupPorAsignar> GroupPorAsignar { get; set; }
        public virtual DbSet<GroupSellado> GroupSellado { get; set; }
        public virtual DbSet<Iedetbkp> Iedetbkp { get; set; }
        public virtual DbSet<Ieencbkp> Ieencbkp { get; set; }
        public virtual DbSet<Inbodega> Inbodega { get; set; }
        public virtual DbSet<Indetaju> Indetaju { get; set; }
        public virtual DbSet<Indevdet> Indevdet { get; set; }
        public virtual DbSet<Indevenc> Indevenc { get; set; }
        public virtual DbSet<Indprdet> Indprdet { get; set; }
        public virtual DbSet<Indprdnc> Indprdnc { get; set; }
        public virtual DbSet<Indprenc> Indprenc { get; set; }
        public virtual DbSet<Indscdet> Indscdet { get; set; }
        public virtual DbSet<Indscenc> Indscenc { get; set; }
        public virtual DbSet<Inentdet> Inentdet { get; set; }
        public virtual DbSet<InentdetCompras2019> InentdetCompras2019 { get; set; }
        public virtual DbSet<InentdetComprasCm> InentdetComprasCm { get; set; }
        public virtual DbSet<Inentenc> Inentenc { get; set; }
        public virtual DbSet<InentencFlujos> InentencFlujos { get; set; }
        public virtual DbSet<Inhstinv> Inhstinv { get; set; }
        public virtual DbSet<Inhstlot> Inhstlot { get; set; }
        public virtual DbSet<Ininvent> Ininvent { get; set; }
        public virtual DbSet<Ininvloc> Ininvloc { get; set; }
        public virtual DbSet<Ininvlot> Ininvlot { get; set; }
        public virtual DbSet<Inprebkp> Inprebkp { get; set; }
        public virtual DbSet<Inpreped> Inpreped { get; set; }
        public virtual DbSet<InprepedCantGuiaCant> InprepedCantGuiaCant { get; set; }
        public virtual DbSet<Intrabkp> Intrabkp { get; set; }
        public virtual DbSet<Intraest> Intraest { get; set; }
        public virtual DbSet<Intrahst> Intrahst { get; set; }
        public virtual DbSet<InventarioDisponible> InventarioDisponible { get; set; }
        public virtual DbSet<InventarioDisponible993> InventarioDisponible993 { get; set; }
        public virtual DbSet<InventarioDisponible994> InventarioDisponible994 { get; set; }
        public virtual DbSet<InventarioDisponibleGer> InventarioDisponibleGer { get; set; }
        public virtual DbSet<InventarioFranquicias> InventarioFranquicias { get; set; }
        public virtual DbSet<InventarioLotes993> InventarioLotes993 { get; set; }
        public virtual DbSet<InventarioLotes994> InventarioLotes994 { get; set; }
        public virtual DbSet<InventarioLotesDisponibles> InventarioLotesDisponibles { get; set; }
        public virtual DbSet<InventarioRetail> InventarioRetail { get; set; }
        public virtual DbSet<InventarioRetailV01> InventarioRetailV01 { get; set; }
        public virtual DbSet<InventarioSimple> InventarioSimple { get; set; }
        public virtual DbSet<InventarioVendible> InventarioVendible { get; set; }
        public virtual DbSet<Lgasigna> Lgasigna { get; set; }
        public virtual DbSet<Lgcubdse> Lgcubdse { get; set; }
        public virtual DbSet<Lgcubseg> Lgcubseg { get; set; }
        public virtual DbSet<Lgetique> Lgetique { get; set; }
        public virtual DbSet<Lgmtrans> Lgmtrans { get; set; }
        public virtual DbSet<Lgmzonas> Lgmzonas { get; set; }
        public virtual DbSet<Lgperbod> Lgperbod { get; set; }
        public virtual DbSet<Lgperson> Lgperson { get; set; }
        public virtual DbSet<Lgtransp> Lgtransp { get; set; }
        public virtual DbSet<Lgtrcozo> Lgtrcozo { get; set; }
        public virtual DbSet<MaestroDeArtículos> MaestroDeArtículos { get; set; }
        public virtual DbSet<PedidosAsignados> PedidosAsignados { get; set; }
        public virtual DbSet<PedidosDespacho> PedidosDespacho { get; set; }
        public virtual DbSet<PedidosPorAsignar> PedidosPorAsignar { get; set; } 
        public virtual DbSet<PedidosPorRepasar> PedidosPorRepasar { get; set; }
        public virtual DbSet<PedidosPreparacion> PedidosPreparacion { get; set; }
        public virtual DbSet<PedidoseEmpaque> PedidoseEmpaque { get; set; }
        public virtual DbSet<Picking> Picking { get; set; }
        public virtual DbSet<Preparacion> Preparacion { get; set; }
        public virtual DbSet<ProductosPendientesDeRecepción> ProductosPendientesDeRecepción { get; set; }
        public virtual DbSet<RfStatus> RfStatus { get; set; }
        public virtual DbSet<SgifDatosArtículos> SgifDatosArtículos { get; set; }
        public virtual DbSet<SgifInventarioVendible> SgifInventarioVendible { get; set; }
        public virtual DbSet<Sicajmov> Sicajmov { get; set; }
        public virtual DbSet<Siciudad> Siciudad { get; set; }
        public virtual DbSet<Siclases> Siclases { get; set; }
        public virtual DbSet<Sicltera> Sicltera { get; set; }
        public virtual DbSet<Sicobrad> Sicobrad { get; set; }
        public virtual DbSet<Sicoment> Sicoment { get; set; }
        public virtual DbSet<Sicomuna> Sicomuna { get; set; }
        public virtual DbSet<SicomunaDatos> SicomunaDatos { get; set; }
        public virtual DbSet<Siconcam> Siconcam { get; set; }
        public virtual DbSet<Sidusers> Sidusers { get; set; }
        public virtual DbSet<Siforfar> Siforfar { get; set; }
        public virtual DbSet<Sifpagos> Sifpagos { get; set; }
        public virtual DbSet<Sigirosr> Sigirosr { get; set; }
        public virtual DbSet<Sigruaso> Sigruaso { get; set; }
        public virtual DbSet<Sigrupos> Sigrupos { get; set; }
        public virtual DbSet<Simacodb> Simacodb { get; set; }
        public virtual DbSet<SimacodbBuscarDuplicados> SimacodbBuscarDuplicados { get; set; }
        public virtual DbSet<Simaerut> Simaerut { get; set; }
        public virtual DbSet<SimaerutClientes> SimaerutClientes { get; set; }
        public virtual DbSet<Simalabo> Simalabo { get; set; }
        public virtual DbSet<Simaprod> Simaprod { get; set; }
        public virtual DbSet<SimaprodPrecioRef0YPrecioVen0> SimaprodPrecioRef0YPrecioVen0 { get; set; }
        public virtual DbSet<SimaprodProductos> SimaprodProductos { get; set; }
        public virtual DbSet<SimaprodVentas> SimaprodVentas { get; set; }
        public virtual DbSet<Simoncon> Simoncon { get; set; }
        public virtual DbSet<Simoneda> Simoneda { get; set; }
        public virtual DbSet<Simotivo> Simotivo { get; set; }
        public virtual DbSet<Sipaises> Sipaises { get; set; }
        public virtual DbSet<Siparamg> Siparamg { get; set; }
        public virtual DbSet<Sipracti> Sipracti { get; set; }
        public virtual DbSet<Sirutcon> Sirutcon { get; set; }
        public virtual DbSet<Sirutdir> Sirutdir { get; set; }
        public virtual DbSet<Sirutrsn> Sirutrsn { get; set; }
        public virtual DbSet<Sisubcla> Sisubcla { get; set; }
        public virtual DbSet<Sitipcom> Sitipcom { get; set; }
        public virtual DbSet<Siunicon> Siunicon { get; set; }
        public virtual DbSet<Siunidad> Siunidad { get; set; }
        public virtual DbSet<StatusNventa> StatusNventa { get; set; }
        public virtual DbSet<SysDmAuditActions> SysDmAuditActions { get; set; }
        public virtual DbSet<Vecotdet> Vecotdet { get; set; }
        public virtual DbSet<Vecotenc> Vecotenc { get; set; }
        public virtual DbSet<Veguidet> Veguidet { get; set; }
        public virtual DbSet<VeguidetEliminaDatos> VeguidetEliminaDatos { get; set; }
        public virtual DbSet<Veguienc> Veguienc { get; set; }
        public virtual DbSet<Velicdet> Velicdet { get; set; }
        public virtual DbSet<Velicenc> Velicenc { get; set; }
        public virtual DbSet<Velispre> Velispre { get; set; }
        public virtual DbSet<Velispva> Velispva { get; set; }
        public virtual DbSet<Velocbod> Velocbod { get; set; }
        public virtual DbSet<Velocven> Velocven { get; set; }
        public virtual DbSet<Vemcajas> Vemcajas { get; set; }
        public virtual DbSet<Vemcanal> Vemcanal { get; set; }
        public virtual DbSet<Vemlocal> Vemlocal { get; set; }
        public virtual DbSet<Vemventa> Vemventa { get; set; }
        public virtual DbSet<Vemzonas> Vemzonas { get; set; }
        public virtual DbSet<Venotdet> Venotdet { get; set; }
        public virtual DbSet<Venovent> Venovent { get; set; }
        public virtual DbSet<Ventatem> Ventatem { get; set; }
        public virtual DbSet<Vepeddet> Vepeddet { get; set; }
        public virtual DbSet<VepeddetCantPrepCantres> VepeddetCantPrepCantres { get; set; }
        public virtual DbSet<VepeddetGuiaReserva> VepeddetGuiaReserva { get; set; }
        public virtual DbSet<VepeddetProducto> VepeddetProducto { get; set; }
        public virtual DbSet<Vepedenc> Vepedenc { get; set; }
        public virtual DbSet<Vetclbod> Vetclbod { get; set; }
        public virtual DbSet<Vetipcli> Vetipcli { get; set; }
        public virtual DbSet<Vetipven> Vetipven { get; set; }
        public virtual DbSet<Vevenenc> Vevenenc { get; set; }
        public virtual DbSet<VevenencVenta2017> VevenencVenta2017 { get; set; }
        public virtual DbSet<VevenencVentaHistórica> VevenencVentaHistórica { get; set; }
        public virtual DbSet<Vezonatr> Vezonatr { get; set; }
        public virtual DbSet<ZCarga> ZCarga { get; set; }
        public virtual DbSet<ZCargaGetransp> ZCargaGetransp { get; set; }
        public virtual DbSet<ZCargaRut> ZCargaRut { get; set; }
        public virtual DbSet<ZFarma> ZFarma { get; set; }
        public virtual DbSet<ZInformeVentas> ZInformeVentas { get; set; }
        public virtual DbSet<ZVentasListadoVendedores> ZVentasListadoVendedores { get; set; }
        public virtual DbSet<ZxCantidadLineasporNotadeventaFacturadas> ZxCantidadLineasporNotadeventaFacturadas { get; set; }
        public virtual DbSet<ZxCantidaddeitemenpreparacion> ZxCantidaddeitemenpreparacion { get; set; }
        public virtual DbSet<ZxClientes> ZxClientes { get; set; }
        public virtual DbSet<ZxConsolidadoImpreped> ZxConsolidadoImpreped { get; set; }
        public virtual DbSet<ZxCountPreparaciones> ZxCountPreparaciones { get; set; }
        public virtual DbSet<ZxCoutDfact> ZxCoutDfact { get; set; }
        public virtual DbSet<ZxDatosDespacho> ZxDatosDespacho { get; set; }
        public virtual DbSet<ZxEsFarma> ZxEsFarma { get; set; }
        public virtual DbSet<ZxFacturado> ZxFacturado { get; set; }
        public virtual DbSet<ZxFechasDespachos> ZxFechasDespachos { get; set; }
        public virtual DbSet<ZxGuiayPreparacion> ZxGuiayPreparacion { get; set; }
        public virtual DbSet<ZxInvRotacionVencimiento> ZxInvRotacionVencimiento { get; set; }
        public virtual DbSet<ZxItemsFacturados> ZxItemsFacturados { get; set; }
        public virtual DbSet<ZxLineasPreparas> ZxLineasPreparas { get; set; }
        public virtual DbSet<ZxListadoVendedores> ZxListadoVendedores { get; set; }
        public virtual DbSet<ZxMovimientodeInventario> ZxMovimientodeInventario { get; set; }
        public virtual DbSet<ZxNotadeVentasStatus1> ZxNotadeVentasStatus1 { get; set; }
        public virtual DbSet<ZxNotadeVentasStatus2> ZxNotadeVentasStatus2 { get; set; }
        public virtual DbSet<ZxNvdiarias> ZxNvdiarias { get; set; }
        public virtual DbSet<ZxPickingAreaP> ZxPickingAreaP { get; set; }
        public virtual DbSet<ZxPreparacionLg> ZxPreparacionLg { get; set; }
        public virtual DbSet<ZxProdUbicaciones> ZxProdUbicaciones { get; set; }
        public virtual DbSet<ZxRotaciondeInventario> ZxRotaciondeInventario { get; set; }
        public virtual DbSet<ZxStatusdeNv> ZxStatusdeNv { get; set; }
        public virtual DbSet<ZxTiempoPreparacion> ZxTiempoPreparacion { get; set; }
        public virtual DbSet<ZxTipoBodega> ZxTipoBodega { get; set; }
        public virtual DbSet<ZxTrasportesTime> ZxTrasportesTime { get; set; }
        public virtual DbSet<ZxVenta> ZxVenta { get; set; }
        public virtual DbSet<ZxVentaporPreparacion> ZxVentaporPreparacion { get; set; }
        public virtual DbSet<ZzSysCfFactura> ZzSysCfFactura { get; set; }
        public virtual DbSet<ZzSysGuíaComprasAnual> ZzSysGuíaComprasAnual { get; set; }
        public virtual DbSet<ZzSysGuíaProductoUn> ZzSysGuíaProductoUn { get; set; }
        public virtual DbSet<ZzSysInventarioVendible> ZzSysInventarioVendible { get; set; }
        public virtual DbSet<ZzSysIqviaEst> ZzSysIqviaEst { get; set; }
        public virtual DbSet<ZzSysNcComprasAnual> ZzSysNcComprasAnual { get; set; }
        public virtual DbSet<ZzSysNcFactura> ZzSysNcFactura { get; set; }
        public virtual DbSet<ZzSysNcProductoUn> ZzSysNcProductoUn { get; set; }
        public virtual DbSet<ZzSysNdFactura> ZzSysNdFactura { get; set; }
        public virtual DbSet<ZzSysNdProductoUn> ZzSysNdProductoUn { get; set; }
        public virtual DbSet<ZzSysNotasDeVentaClientesPendientes> ZzSysNotasDeVentaClientesPendientes { get; set; }
        public virtual DbSet<ZzSysNotasDeVentaPendientes> ZzSysNotasDeVentaPendientes { get; set; }
        public virtual DbSet<ZzSysNotasDeVentaRepaso> ZzSysNotasDeVentaRepaso { get; set; }
        public virtual DbSet<ZzSysNotasDeVentaRepasoProducto> ZzSysNotasDeVentaRepasoProducto { get; set; }
        public virtual DbSet<ZzSysOrdenesDeCompraPendientes> ZzSysOrdenesDeCompraPendientes { get; set; }
        public virtual DbSet<ZzSysPagosFactura> ZzSysPagosFactura { get; set; }
        public virtual DbSet<ZzSysPetitorioInventario> ZzSysPetitorioInventario { get; set; }
        public virtual DbSet<ZzSysVentasPeríodo> ZzSysVentasPeríodo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=192.168.0.97;Initial Catalog=Global;user id=globalsql;password=010101zxAS");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cmetaslp>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Código)
                    .HasName("CMETASLP$Código");

                entity.HasIndex(e => e.Ffin)
                    .HasName("CMETASLP$Final");

                entity.HasIndex(e => e.Fini)
                    .HasName("CMETASLP$Inicio");

                entity.HasIndex(e => e.TipoCód)
                    .HasName("CMETASLP$Tipo");

                entity.HasIndex(e => e.Vendedor)
                    .HasName("CMETASLP$Vendedor");

                entity.Property(e => e.Contribución)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Meta de Contribución");

                entity.Property(e => e.Código).HasComment("Código puede ser del Tipo Producto o Tipo Laboratorio");

                entity.Property(e => e.Ffin).HasComment("Fecha Término Período");

                entity.Property(e => e.Fini).HasComment("Fecha Inicio Período");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TipoCód).HasComment("P: Producto o L:Laboratorio");

                entity.Property(e => e.Vendedor)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Código del Vendedor");

                entity.Property(e => e.Venta)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Meta de Ventas");

                entity.Property(e => e.Venta01).HasDefaultValueSql("((0))");

                entity.Property(e => e.Venta03).HasDefaultValueSql("((0))");

                entity.Property(e => e.Venta04).HasDefaultValueSql("((0))");

                entity.Property(e => e.Venta05).HasDefaultValueSql("((0))");

                entity.Property(e => e.Venta06).HasDefaultValueSql("((0))");

                entity.Property(e => e.VentaP).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Coarchfo>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Desde)
                    .HasName("COARCHFO$Fecha");

                entity.HasIndex(e => e.Folio)
                    .HasName("COARCHFO$Documento");

                entity.Property(e => e.Desde).HasComment("Fecha Inicio Proceso");

                entity.Property(e => e.Folio).HasDefaultValueSql("((0))");

                entity.Property(e => e.Hasta).HasComment("Fecha Término Proceso");

                entity.Property(e => e.Tipo).HasComment("P: Pagos F: Facturas");
            });

            modelBuilder.Entity<Cobancos>(entity =>
            {
                entity.HasKey(e => e.CodBan)
                    .HasName("COBANCOS$PrimaryKey");
            });

            modelBuilder.Entity<Cofactor>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Vendedor)
                    .HasName("COFACTOR$Vendedor");

                entity.Property(e => e.Factor).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Vendedor).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Commetas>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Ffin)
                    .HasName("COMMETAS$Final");

                entity.HasIndex(e => e.Fini)
                    .HasName("COMMETAS$Inicio");

                entity.HasIndex(e => e.Vendedor)
                    .HasName("COMMETAS$Vendedor");

                entity.Property(e => e.Contribución).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Vendedor).HasDefaultValueSql("((0))");

                entity.Property(e => e.Venta).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Compagos>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.BancoDep)
                    .HasName("COMPAGOS$Banco Deposito");

                entity.HasIndex(e => e.CodBan)
                    .HasName("COMPAGOS$Banco");

                entity.HasIndex(e => e.CodTdoc)
                    .HasName("COMPAGOS$Tipo Documento");

                entity.HasIndex(e => e.Estado)
                    .HasName("COMPAGOS$Estado")
                    .IsClustered();

                entity.HasIndex(e => e.Factura)
                    .HasName("COMPAGOS$Factura");

                entity.HasIndex(e => e.Fecha)
                    .HasName("COMPAGOS$Fecha");

                entity.HasIndex(e => e.FechaDoc)
                    .HasName("COMPAGOS$Fecha Documento");

                entity.HasIndex(e => e.NumDoc)
                    .HasName("COMPAGOS$Número de Documento");

                entity.HasIndex(e => e.Referencia)
                    .HasName("COMPAGOS$Referencia");

                entity.HasIndex(e => e.Rut)
                    .HasName("COMPAGOS$RUT");

                entity.Property(e => e.DocaFecha).HasDefaultValueSql("('N')");

                entity.Property(e => e.Estado).HasDefaultValueSql("('V')");

                entity.Property(e => e.MontoDoc).HasDefaultValueSql("((0))");

                entity.Property(e => e.Regularizado).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<CompagosRespaldo>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.BancoDep)
                    .HasName("COMPAGOS Respaldo$Banco Deposito");

                entity.HasIndex(e => e.CodBan)
                    .HasName("COMPAGOS Respaldo$Banco");

                entity.HasIndex(e => e.CodTdoc)
                    .HasName("COMPAGOS Respaldo$Tipo Documento");

                entity.HasIndex(e => e.Factura)
                    .HasName("COMPAGOS Respaldo$Factura");

                entity.HasIndex(e => e.Fecha)
                    .HasName("COMPAGOS Respaldo$Fecha");

                entity.HasIndex(e => e.FechaDoc)
                    .HasName("COMPAGOS Respaldo$Fecha Documento");

                entity.HasIndex(e => e.Rut)
                    .HasName("COMPAGOS Respaldo$RUT");

                entity.Property(e => e.DocaFecha).HasDefaultValueSql("('N')");

                entity.Property(e => e.Estado).HasDefaultValueSql("('V')");

                entity.Property(e => e.MontoDoc).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Copagoco>(entity =>
            {
                entity.HasKey(e => e.Factura)
                    .HasName("COPAGOCO$PrimaryKey");

                entity.HasIndex(e => e.Rut)
                    .HasName("COPAGOCO$RUT");

                entity.HasIndex(e => e.Vendedor)
                    .HasName("COPAGOCO$Vendedor");

                entity.Property(e => e.AbonoPa).HasDefaultValueSql("((0))");

                entity.Property(e => e.ChequeAFecha).HasDefaultValueSql("((0))");

                entity.Property(e => e.Comision).HasDefaultValueSql("((0))");

                entity.Property(e => e.ComisionSup).HasDefaultValueSql("((0))");

                entity.Property(e => e.Contribucion).HasDefaultValueSql("((0))");

                entity.Property(e => e.Factor).HasDefaultValueSql("((0))");

                entity.Property(e => e.FactorSup).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nc).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nd).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pagos).HasDefaultValueSql("((0))");

                entity.Property(e => e.Saldo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Total).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vendedor).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Copagotr>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.CodBanco)
                    .HasName("COPAGOTR$Banco");

                entity.HasIndex(e => e.Documento)
                    .HasName("COPAGOTR$Doc");

                entity.HasIndex(e => e.Fecha)
                    .HasName("COPAGOTR$Fecha");

                entity.Property(e => e.Documento).HasComment("Factura o Guìa");

                entity.Property(e => e.Monto).HasDefaultValueSql("((0))");

                entity.Property(e => e.Movimiento)
                    .HasDefaultValueSql("('C')")
                    .HasComment("E: Efectivo C:Cheque");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Tipo)
                    .HasDefaultValueSql("('F')")
                    .HasComment("Tipo de Documento G: Guìa F: Factura");
            });

            modelBuilder.Entity<Copagtbk>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Cuotas)
                    .HasName("COPAGTBK$Banco");

                entity.HasIndex(e => e.Factura)
                    .HasName("COPAGTBK$Factura");

                entity.HasIndex(e => e.Monto)
                    .HasName("COPAGTBK$Tipo Documento");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Corespag>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Rut)
                    .HasName("CORESPAG$RUT");

                entity.HasIndex(e => e.Vendedor)
                    .HasName("CORESPAG$Vendedor");

                entity.Property(e => e.Nc).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nd).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pagos).HasDefaultValueSql("((0))");

                entity.Property(e => e.Saldo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Total).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vendedor).HasDefaultValueSql("((0))");

                entity.Property(e => e._030).HasDefaultValueSql("((0))");

                entity.Property(e => e._121365).HasDefaultValueSql("((0))");

                entity.Property(e => e._3160).HasDefaultValueSql("((0))");

                entity.Property(e => e._365m).HasDefaultValueSql("((0))");

                entity.Property(e => e._6190).HasDefaultValueSql("((0))");

                entity.Property(e => e._91120).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Cotipdoc>(entity =>
            {
                entity.HasKey(e => e.CodTdoc)
                    .HasName("COTIPDOC$PrimaryKey");
            });

            modelBuilder.Entity<DboCmetaslp>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<EresumenNotadeVenta>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EResumenNotadeVenta");
            });

            modelBuilder.Entity<ErroresAlGuardarAutocorrecciónDeNombres>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Hora).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ErroresDePegado>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<FletesZonas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Fletes_Zonas");
            });

            modelBuilder.Entity<Geocmdet>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.CodBase)
                    .HasName("GEOCMDET$codbase");

                entity.HasIndex(e => e.Estado)
                    .HasName("GEOCMDET$estado");

                entity.HasIndex(e => e.NumLin)
                    .HasName("GEOCMDET$numlin");

                entity.HasIndex(e => e.Numoc)
                    .HasName("GEOCMDET$numoc");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Geocmenc>(entity =>
            {
                entity.HasKey(e => e.NumOc)
                    .HasName("GEOCMENC$PrimaryKey");

                entity.HasIndex(e => e.CodMon)
                    .HasName("GEOCMENC$Moneda");

                entity.HasIndex(e => e.Estado)
                    .HasName("GEOCMENC$estado");

                entity.HasIndex(e => e.Fecha)
                    .HasName("GEOCMENC$fecha");

                entity.HasIndex(e => e.RutPro)
                    .HasName("GEOCMENC$rutpro");

                entity.Property(e => e.AfEx).HasComment("A: Afecta, E:Exenta");

                entity.Property(e => e.Días).HasDefaultValueSql("((0))");

                entity.Property(e => e.Estado).HasComment("A: Abierta; G: Generada; C: Cerrada; P:Parcial; N: Anulada");

                entity.Property(e => e.Iva).HasDefaultValueSql("((0))");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Getransp>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Boleto)
                    .HasName("GETRANSP$Boleto");

                entity.HasIndex(e => e.Factura)
                    .HasName("GETRANSP$Factura");

                entity.HasIndex(e => e.NumGuia)
                    .HasName("GETRANSP$Guía");

                entity.HasIndex(e => e.Trans)
                    .HasName("GETRANSP$Trans");

                entity.HasIndex(e => e.Transporte)
                    .HasName("GETRANSP$Transporte");

                entity.Property(e => e.Alto).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ancho).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bultos).HasDefaultValueSql("((0))");

                entity.Property(e => e.EnRuta).HasDefaultValueSql("((0))");

                entity.Property(e => e.Flete).HasDefaultValueSql("((0))");

                entity.Property(e => e.Largo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.Peso).HasDefaultValueSql("((0))");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Trans).HasComment("I INterno L:Lit P: Prosegur");

                entity.Property(e => e.ValorDe).HasDefaultValueSql("((0))");

                entity.Property(e => e.Volumen).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GetranspCargaDatosTransportes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GETRANSP Carga Datos Transportes");
            });

            modelBuilder.Entity<GetranspTransporteMóvil>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GETRANSP Transporte Móvil");
            });

            modelBuilder.Entity<GetranspTransportes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GETRANSP Transportes");
            });

            modelBuilder.Entity<Getrasps>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<GroupDespacho>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GroupDespacho");
            });

            modelBuilder.Entity<GroupFacturado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GroupFacturado");
            });

            modelBuilder.Entity<GroupPicking>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GroupPicking");
            });

            modelBuilder.Entity<GroupPorAsignar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GroupPorAsignar");
            });

            modelBuilder.Entity<GroupSellado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GroupSellado");
            });

            modelBuilder.Entity<Iedetbkp>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Codigob)
                    .HasName("IEDETBKP$codigob");

                entity.HasIndex(e => e.Codmp)
                    .HasName("IEDETBKP$codmp");

                entity.HasIndex(e => e.Estado)
                    .HasName("IEDETBKP$estado");

                entity.HasIndex(e => e.Folio)
                    .HasName("IEDETBKP$folio");

                entity.HasIndex(e => e.Ordc)
                    .HasName("IEDETBKP$Orden de Compra");

                entity.Property(e => e.Descp).HasDefaultValueSql("((0))");

                entity.Property(e => e.Factorc).HasDefaultValueSql("((1))");

                entity.Property(e => e.Numlin).HasDefaultValueSql("((0))");

                entity.Property(e => e.Potencia).HasDefaultValueSql("((0))");

                entity.Property(e => e.Precuni).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pref).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Totrec).HasDefaultValueSql("((0))");

                entity.Property(e => e.Totteo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Valtot).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ieencbkp>(entity =>
            {
                entity.HasKey(e => e.Folio)
                    .HasName("IEENCBKP$PrimaryKey");

                entity.HasIndex(e => e.Codbod)
                    .HasName("IEENCBKP$Bodega");

                entity.HasIndex(e => e.Oc)
                    .HasName("IEENCBKP$Orden de Compra");

                entity.HasIndex(e => e.RutPrv)
                    .HasName("IEENCBKP$Proveedor");

                entity.Property(e => e.AfEx).HasComment("A: Afecta, E: Exenta");

                entity.Property(e => e.Contabilizado)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0: No 1 : Si");

                entity.Property(e => e.DiasPago).HasDefaultValueSql("((0))");

                entity.Property(e => e.Estado).HasComment("ESTADO V,A");

                entity.Property(e => e.Fechaa).HasComment("FECHA DE LA ANULACION");

                entity.Property(e => e.Impreso).HasComment("INDICA SI LA ORDEN FUE IMPRESA S,N");

                entity.Property(e => e.Impuesto)
                    .HasDefaultValueSql("((0))")
                    .HasComment("IVA");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pagado).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Tipodoc).HasComment("TIPO DE DOCUMENTO CON  QUE LLEGA F,G,O (FACTURA, GUIA, OTRA)");

                entity.Property(e => e.Usuarioa).HasComment("USUARIO QUIEN REALIZA LA ANULACION");
            });

            modelBuilder.Entity<Inbodega>(entity =>
            {
                entity.HasKey(e => e.CodigoBod)
                    .HasName("INBODEGA$INBODCOD");

                entity.HasIndex(e => e.Vendible)
                    .HasName("NonClusteredIndex-20190829-171320");

                entity.Property(e => e.Listado).HasDefaultValueSql("('N')");

                entity.Property(e => e.Lotes).HasDefaultValueSql("('N')");

                entity.Property(e => e.Ubica).HasDefaultValueSql("('N')");

                entity.Property(e => e.Vendible).HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<Indetaju>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Diferencia).HasDefaultValueSql("((0))");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.Potencia).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StockC).HasDefaultValueSql("((0))");

                entity.Property(e => e.StockF).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Indevdet>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Codmp)
                    .HasName("INDEVDET$codmp");

                entity.HasIndex(e => e.EstGuia)
                    .HasName("INDEVDET$estguia");

                entity.HasIndex(e => e.NumGuia)
                    .HasName("INDEVDET$NumGuia");

                entity.Property(e => e.CantADev).HasDefaultValueSql("((0))");

                entity.Property(e => e.Costop).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinPed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nc).HasDefaultValueSql("('N')");

                entity.Property(e => e.PrGuía).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioP).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Indevenc>(entity =>
            {
                entity.HasKey(e => e.NumGuia)
                    .HasName("INDEVENC$PrimaryKey");

                entity.HasIndex(e => e.EstGuia)
                    .HasName("INDEVENC$estado_guia");

                entity.HasIndex(e => e.EstVenta)
                    .HasName("INDEVENC$estado_venta");

                entity.HasIndex(e => e.Estado)
                    .HasName("INDEVENC$estado");

                entity.HasIndex(e => e.Fecha)
                    .HasName("INDEVENC$fecha");

                entity.HasIndex(e => e.NumFac)
                    .HasName("INDEVENC$Factura");

                entity.HasIndex(e => e.RutCli)
                    .HasName("INDEVENC$rutcli");

                entity.HasIndex(e => e.TipoGuía)
                    .HasName("INDEVENC$tipo");

                entity.HasIndex(e => e.Vendedor)
                    .HasName("INDEVENC$vendedor");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vendedor).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Indprdet>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Codmp)
                    .HasName("INDPRDET$codmp");

                entity.HasIndex(e => e.Folio)
                    .HasName("INDPRDET$NumGuia");

                entity.Property(e => e.Canjes).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantADev).HasDefaultValueSql("((0))");

                entity.Property(e => e.Motivo).HasComment("D: Deteriorados P; Pronto Vence, N: No solicitado; O: Otros");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ValorL).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Indprdnc>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Fecha)
                    .HasName("INDPRDNC$fecha");

                entity.HasIndex(e => e.Folio)
                    .HasName("INDPRDNC$Folio");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ValorT).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Indprenc>(entity =>
            {
                entity.HasKey(e => e.Folio)
                    .HasName("INDPRENC$PrimaryKey");

                entity.HasIndex(e => e.Estado)
                    .HasName("INDPRENC$estado");

                entity.HasIndex(e => e.Fecha)
                    .HasName("INDPRENC$fecha");

                entity.HasIndex(e => e.Referencia)
                    .HasName("INDPRENC$Documento");

                entity.HasIndex(e => e.RutPrv)
                    .HasName("INDPRENC$rutcli");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Tdocs).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tipo).HasComment("I: Ingreso; G: Guía de Despacho");
            });

            modelBuilder.Entity<Indscdet>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Codmp)
                    .HasName("INDSCDET$codmp");

                entity.HasIndex(e => e.EstGuia)
                    .HasName("INDSCDET$estguia");

                entity.HasIndex(e => e.NumGuia)
                    .HasName("INDSCDET$NumGuia");

                entity.Property(e => e.CantADev).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantNc).HasDefaultValueSql("((0))");

                entity.Property(e => e.Costop).HasDefaultValueSql("((0))");

                entity.Property(e => e.FolioNc).HasDefaultValueSql("('0000000000')");

                entity.Property(e => e.LinPed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nc).HasDefaultValueSql("('N')");

                entity.Property(e => e.PrGuía).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioP).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Indscenc>(entity =>
            {
                entity.HasKey(e => e.NumGuia)
                    .HasName("INDSCENC$PrimaryKey");

                entity.HasIndex(e => e.EstGuia)
                    .HasName("INDSCENC$estado_guia");

                entity.HasIndex(e => e.EstVenta)
                    .HasName("INDSCENC$estado_venta");

                entity.HasIndex(e => e.Estado)
                    .HasName("INDSCENC$estado");

                entity.HasIndex(e => e.Fecha)
                    .HasName("INDSCENC$fecha");

                entity.HasIndex(e => e.NumFac)
                    .HasName("INDSCENC$Factura");

                entity.HasIndex(e => e.RutCli)
                    .HasName("INDSCENC$rutcli");

                entity.HasIndex(e => e.TipoGuía)
                    .HasName("INDSCENC$tipo");

                entity.HasIndex(e => e.Vendedor)
                    .HasName("INDSCENC$vendedor");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vendedor).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Inentdet>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Codigob)
                    .HasName("INENTDET$codigob");

                entity.HasIndex(e => e.Codmp)
                    .HasName("INENTDET$codmp");

                entity.HasIndex(e => e.Estado)
                    .HasName("INENTDET$estado");

                entity.HasIndex(e => e.Folio)
                    .HasName("INENTDET$folio");

                entity.HasIndex(e => e.Lote)
                    .HasName("INENTDET$Lote 20200210-1349");

                entity.HasIndex(e => e.Ordc)
                    .HasName("INENTDET$Orden de Compra");

                entity.Property(e => e.Descp).HasDefaultValueSql("((0))");

                entity.Property(e => e.Factorc).HasDefaultValueSql("((1))");

                entity.Property(e => e.Numlin).HasDefaultValueSql("((0))");

                entity.Property(e => e.Potencia).HasDefaultValueSql("((0))");

                entity.Property(e => e.Precuni).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pref).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Totrec).HasDefaultValueSql("((0))");

                entity.Property(e => e.Totteo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Valtot).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<InentdetCompras2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("INENTDET Compras 2019");
            });

            modelBuilder.Entity<InentdetComprasCm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("INENTDET Compras CM");
            });

            modelBuilder.Entity<Inentenc>(entity =>
            {
                entity.HasKey(e => e.Folio)
                    .HasName("INENTENC$PrimaryKey");

                entity.HasIndex(e => e.Codbod)
                    .HasName("INENTENC$Bodega");

                entity.HasIndex(e => e.Fecha)
                    .HasName("INENTENC$Fecha");

                entity.HasIndex(e => e.Oc)
                    .HasName("INENTENC$Orden de Compra");

                entity.HasIndex(e => e.RutPrv)
                    .HasName("INENTENC$Proveedor");

                entity.Property(e => e.AfEx).HasComment("A: Afecta, E: Exenta");

                entity.Property(e => e.Contabilizado)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0: No 1 : Si");

                entity.Property(e => e.DiasPago).HasDefaultValueSql("((0))");

                entity.Property(e => e.Estado).HasComment("ESTADO V,A");

                entity.Property(e => e.Fechaa).HasComment("FECHA DE LA ANULACION");

                entity.Property(e => e.Impreso).HasComment("INDICA SI LA ORDEN FUE IMPRESA S,N");

                entity.Property(e => e.Impuesto)
                    .HasDefaultValueSql("((0))")
                    .HasComment("IVA");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pagado).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Tipodoc).HasComment("TIPO DE DOCUMENTO CON  QUE LLEGA F,G,O (FACTURA, GUIA, OTRA)");

                entity.Property(e => e.Usuarioa).HasComment("USUARIO QUIEN REALIZA LA ANULACION");
            });

            modelBuilder.Entity<InentencFlujos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("INENTENC Flujos");
            });

            modelBuilder.Entity<Inhstinv>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Codbod)
                    .HasName("INHSTINV$BODEGA");

                entity.HasIndex(e => e.Codmp)
                    .HasName("INHSTINV$codmp");

                entity.HasIndex(e => e.Fechah)
                    .HasName("INHSTINV$fechah");

                entity.Property(e => e.Costo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reserva).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Stock).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Inhstlot>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Codbod)
                    .HasName("INHSTLOT$codbod");

                entity.HasIndex(e => e.Codmp)
                    .HasName("INHSTLOT$codmp");

                entity.HasIndex(e => e.Fechah)
                    .HasName("INHSTLOT$fechah");

                entity.HasIndex(e => e.Nlote)
                    .HasName("INHSTLOT$nlote");

                entity.Property(e => e.Reserva).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Stock).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ininvent>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Codbod)
                    .HasName("ININVENT$BODEGA");

                entity.HasIndex(e => e.Codmp)
                    .HasName("ININVENT$codmp");

                entity.HasIndex(e => e.Pedido)
                    .HasName("ININVENT$pedido");

                entity.HasIndex(e => e.Sf1)
                    .HasName("ININVENT$sf1");

                entity.Property(e => e.Pedido).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reserva).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sf0).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sf1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.St0).HasDefaultValueSql("((0))");

                entity.Property(e => e.Stock).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ininvloc>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Codbod)
                    .HasName("ININVLOC$Bodega");

                entity.HasIndex(e => e.Codigob)
                    .HasName("ININVLOC$Código de Barra");

                entity.HasIndex(e => e.Codmp)
                    .HasName("ININVLOC$Producto");

                entity.HasIndex(e => e.Nlote)
                    .HasName("ININVLOC$Lote");

                entity.HasIndex(e => e.Ubicacion)
                    .HasName("ININVLOC$UBICACION");

                entity.Property(e => e.Reserva).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Stock).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ininvlot>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Codbod)
                    .HasName("ININVLOT$codbod");

                entity.HasIndex(e => e.Codigob)
                    .HasName("ININVLOT$ININVLOTCODIGOB");

                entity.HasIndex(e => e.Codmp)
                    .HasName("ININVLOT$codmp");

                entity.HasIndex(e => e.Nlote)
                    .HasName("ININVLOT$nlote");

                entity.Property(e => e.BioEq).HasDefaultValueSql("((0))");

                entity.Property(e => e.Potencia).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reserva).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sf0).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sf1).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.St0).HasDefaultValueSql("((0))");

                entity.Property(e => e.Stock).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Inprebkp>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Codmp)
                    .HasName("INPREBKP$codmp");

                entity.HasIndex(e => e.EstPrep)
                    .HasName("INPREBKP$estprep");

                entity.HasIndex(e => e.Estado)
                    .HasName("INPREBKP$estado");

                entity.HasIndex(e => e.Folio)
                    .HasName("INPREBKP$folio");

                entity.HasIndex(e => e.Lote)
                    .HasName("INPREBKP$lote");

                entity.HasIndex(e => e.NumPed)
                    .HasName("INPREBKP$Pedido");

                entity.HasIndex(e => e.Ubicacion)
                    .HasName("INPREBKP$ubicacion");

                entity.Property(e => e.CantAnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantGuia).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantHst).HasDefaultValueSql("((0))");

                entity.Property(e => e.Costop).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinPed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<Inpreped>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Bodega)
                    .HasName("INPREPED$Bodega");

                entity.HasIndex(e => e.CantAnt)
                    .HasName("INPREPED$estprep");

                entity.HasIndex(e => e.Codmp)
                    .HasName("INPREPED$codmp");

                entity.HasIndex(e => e.EstPrep)
                    .HasName("INPREPED$Estado Preparación");

                entity.HasIndex(e => e.Estado)
                    .HasName("INPREPED$estado");

                entity.HasIndex(e => e.Fecha)
                    .HasName("INPREPED$Fecha");

                entity.HasIndex(e => e.Folio)
                    .HasName("INPREPED$folio");

                entity.HasIndex(e => e.Lote)
                    .HasName("INPREPED$lote");

                entity.HasIndex(e => e.NumPed)
                    .HasName("INPREPED$Pedido");

                entity.HasIndex(e => e.Status)
                    .HasName("INPREPED$Status");

                entity.HasIndex(e => e.Ubicacion)
                    .HasName("INPREPED$Ubicación");

                entity.Property(e => e.CantAnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantGuia).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantHst).HasDefaultValueSql("((0))");

                entity.Property(e => e.Costop).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinPed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<InprepedCantGuiaCant>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("INPREPED Cant_Guia > Cant");
            });

            modelBuilder.Entity<Intrabkp>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Codmp)
                    .HasName("INTRABKP$CODIGO");

                entity.HasIndex(e => e.Estado)
                    .HasName("INTRABKP$Estado");

                entity.HasIndex(e => e.Folio)
                    .HasName("INTRABKP$CLAVE");

                entity.HasIndex(e => e.Lote)
                    .HasName("INTRABKP$LOTE");

                entity.HasIndex(e => e.Tipo)
                    .HasName("INTRABKP$Tipo");

                entity.Property(e => e.CostoProm).HasDefaultValueSql("((0))");

                entity.Property(e => e.Folio).HasDefaultValueSql("((0))");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Intraest>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Codmp)
                    .HasName("INTRAEST$CODIGO");

                entity.HasIndex(e => e.Estado)
                    .HasName("INTRAEST$Estado");

                entity.HasIndex(e => e.Folio)
                    .HasName("INTRAEST$CLAVE");

                entity.HasIndex(e => e.Lote)
                    .HasName("INTRAEST$LOTE");

                entity.HasIndex(e => e.Tipo)
                    .HasName("INTRAEST$Tipo");

                entity.Property(e => e.CostoProm).HasDefaultValueSql("((0))");

                entity.Property(e => e.Folio).HasDefaultValueSql("((0))");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Intrahst>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Codbod)
                    .HasName("INTRAHST$codbod");

                entity.HasIndex(e => e.Codigop)
                    .HasName("INTRAHST$codigop");

                entity.HasIndex(e => e.Fecha)
                    .HasName("INTRAHST$fecha");

                entity.HasIndex(e => e.Id)
                    .HasName("INTRAHST$idx");

                entity.HasIndex(e => e.Idtra)
                    .HasName("INTRAHST$idtra (20200210-1342)");

                entity.HasIndex(e => e.Ubica)
                    .HasName("INTRAHST$Ubicacion-20200213-1613");

                entity.Property(e => e.CantAct).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantAnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantAntB).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantAntCbB).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantAntCbL).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantAntCbU).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantAntL).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantAntU).HasDefaultValueSql("((0))");

                entity.Property(e => e.Codigob).HasComment("CODIGO DE BODEGA");

                entity.Property(e => e.Codigop).HasComment("CODIGO DE PRODUCTO");

                entity.Property(e => e.CostoAct).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostoAnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lote).HasComment("CODIGO DE LOTE");

                entity.Property(e => e.Referencia).HasComment("DOCUMENTO DE REFERENCIA ORDEN DE COMPRA");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Ubica).HasComment("CODIGO DE UBICACION");
            });

            modelBuilder.Entity<InventarioDisponible>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Inventario Disponible");
            });

            modelBuilder.Entity<InventarioDisponible993>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Inventario Disponible 993");
            });

            modelBuilder.Entity<InventarioDisponible994>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Inventario Disponible 994");
            });

            modelBuilder.Entity<InventarioDisponibleGer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Inventario Disponible Ger");
            });

            modelBuilder.Entity<InventarioFranquicias>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Inventario Franquicias");
            });

            modelBuilder.Entity<InventarioLotes993>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Inventario Lotes 993");
            });

            modelBuilder.Entity<InventarioLotes994>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Inventario Lotes 994");
            });

            modelBuilder.Entity<InventarioLotesDisponibles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Inventario Lotes Disponibles");
            });

            modelBuilder.Entity<InventarioRetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Inventario Retail");
            });

            modelBuilder.Entity<InventarioRetailV01>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Inventario Retail v01");
            });

            modelBuilder.Entity<InventarioSimple>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Inventario Simple");
            });

            modelBuilder.Entity<InventarioVendible>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Inventario Vendible");
            });

            modelBuilder.Entity<Lgasigna>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Area)
                    .HasName("LGASIGNA$Area");

                entity.HasIndex(e => e.Bodega)
                    .HasName("LGASIGNA$Bodega");

                entity.HasIndex(e => e.CodPer)
                    .HasName("LGASIGNA$Personal");

                entity.HasIndex(e => e.Documento)
                    .HasName("LGASIGNA$Documento");

                entity.HasIndex(e => e.Fecha)
                    .HasName("LGASIGNA$Fecha");

                entity.HasIndex(e => e.NumPed)
                    .HasName("LGASIGNA$NumPed");

                entity.HasIndex(e => e.TipoDoc)
                    .HasName("LGASIGNA$Tipo");

                entity.Property(e => e.Area).HasComment("T: Trasportes R:Revisión P: Preparación");

                entity.Property(e => e.Fecha).HasComment("Fecha Inicio Proceso");

                entity.Property(e => e.FechaT).HasComment("Fecha Término Proceso");

                entity.Property(e => e.Líneas).HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoDoc).HasComment("F: Factura G: Guía P:Preparación");

                entity.Property(e => e.Unidades).HasDefaultValueSql("((0))");

                entity.Property(e => e.Valores).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Lgcubdse>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Documento)
                    .HasName("LGCUBDSE$Documento");

                entity.Property(e => e.Cubeta).HasComment("Cubeta en la cual està el folio");

                entity.Property(e => e.Documento).HasComment("Preparación");

                entity.Property(e => e.FolPrep).HasComment("Folio Preparación asociada");

                entity.Property(e => e.Orden)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Nùmero Correlativo de los segutos");

                entity.Property(e => e.Seguro).HasComment("Seguros Número Folio Desde");
            });

            modelBuilder.Entity<Lgcubseg>(entity =>
            {
                entity.HasKey(e => e.Documento)
                    .HasName("LGCUBSEG$PrimaryKey");

                entity.HasIndex(e => e.Fecha)
                    .HasName("LGCUBSEG$Fecha");

                entity.HasIndex(e => e.Usuario)
                    .HasName("LGCUBSEG$Personal");

                entity.Property(e => e.Documento).HasComment("Preparación");

                entity.Property(e => e.Cubetas).HasDefaultValueSql("((0))");

                entity.Property(e => e.Devueltas).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fecha).HasComment("Fecha Entrega Cubetas");

                entity.Property(e => e.FechaDev).HasComment("Fecha Devolución Cubetas");
            });

            modelBuilder.Entity<Lgetique>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Nguía)
                    .HasName("LGETIQUE$Guía(Non clustereddIndex-20191212)");
            });

            modelBuilder.Entity<Lgmtrans>(entity =>
            {
                entity.HasKey(e => e.TrCod)
                    .HasName("LGMTRANS$PrimaryKey");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TrPesoKg).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrPesoVol).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Lgmzonas>(entity =>
            {
                entity.HasKey(e => e.ZnCod)
                    .HasName("LGMZONAS$PrimaryKey");
            });

            modelBuilder.Entity<Lgperbod>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.CodBod)
                    .HasName("LGPERBOD$Cod_Bod");

                entity.HasIndex(e => e.CodPer)
                    .HasName("LGPERBOD$Cod_Per");
            });

            modelBuilder.Entity<Lgperson>(entity =>
            {
                entity.HasKey(e => e.CodPer)
                    .HasName("LGPERSON$PrimaryKey");

                entity.Property(e => e.CodPer).HasComment("Código");

                entity.Property(e => e.DesPer).HasComment("Nombre");

                entity.Property(e => e.Estado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Prep).HasDefaultValueSql("('N')");

                entity.Property(e => e.Rev).HasDefaultValueSql("('N')");

                //entity.Property(e => e.SsmaTimeStamp)
                //    .IsRowVersion()
                //    .IsConcurrencyToken();

                entity.Property(e => e.Trans).HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<Lgtransp>(entity =>
            {
                entity.HasKey(e => e.CodTrans)
                    .HasName("LGTRANSP$PrimaryKey");
            });

            modelBuilder.Entity<Lgtrcozo>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.CodCom)
                    .HasName("LGTRCOZO$comuna");

                entity.HasIndex(e => e.TrCod)
                    .HasName("LGTRCOZO$codigo");

                entity.HasIndex(e => e.ZnCod)
                    .HasName("LGTRCOZO$zona");
            });

            modelBuilder.Entity<MaestroDeArtículos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Maestro de Artículos");
            });

            modelBuilder.Entity<PedidosAsignados>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PedidosAsignados");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<PedidosDespacho>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PedidosDespacho");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<PedidosPorAsignar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PedidosPorAsignar");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<PedidosPorRepasar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pedidos por Repasar");
            });

            modelBuilder.Entity<PedidosPreparacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PedidosPreparacion");

                entity.Property(e => e.Ncaja).IsUnicode(false);

                entity.Property(e => e.Sdaitm).IsUnicode(false);

                entity.Property(e => e.Sddoco).IsUnicode(false);

                entity.Property(e => e.Sddsc1).IsUnicode(false);

                entity.Property(e => e.Sddsc2).IsUnicode(false);

                entity.Property(e => e.Sdvr01).IsUnicode(false);
            });

            modelBuilder.Entity<PedidoseEmpaque>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PedidoseEmpaque");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<Picking>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Picking");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<Preparacion>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CantVali).HasDefaultValueSql("((0))");

                entity.Property(e => e.Dimensiones).IsUnicode(false);

                entity.Property(e => e.Id).HasDefaultValueSql("((1))");

                entity.Property(e => e.Lote).IsUnicode(false);

                entity.Property(e => e.Ncaja).IsUnicode(false);

                entity.Property(e => e.Ncaja1).IsUnicode(false);

                entity.Property(e => e.Npallet).IsUnicode(false);

                entity.Property(e => e.Obs).IsUnicode(false);

                entity.Property(e => e.Origen).IsUnicode(false);

                entity.Property(e => e.Sdaitm).IsUnicode(false);

                entity.Property(e => e.Sdan8).IsFixedLength();

                entity.Property(e => e.Sddoco).IsUnicode(false);

                entity.Property(e => e.Sddsc1).IsUnicode(false);

                entity.Property(e => e.Sddsc2).IsUnicode(false);

                entity.Property(e => e.Sdvr01).IsUnicode(false);

                entity.Property(e => e.Skucliente).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TipoCaja).IsUnicode(false);

                entity.Property(e => e.TipoProd).IsUnicode(false);

                entity.Property(e => e.UsuarioEmbarque).IsUnicode(false);

                entity.Property(e => e.UsuarioEtiq).IsUnicode(false);

                entity.Property(e => e.UsuarioRecpEtiq).IsUnicode(false);

                entity.Property(e => e.UsuarioRecpSellado).IsUnicode(false);

                entity.Property(e => e.UsuarioSellado).IsUnicode(false);

                entity.Property(e => e.Usuariodespacho).IsUnicode(false);
            });

            modelBuilder.Entity<ProductosPendientesDeRecepción>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Productos Pendientes de Recepción");
            });

            modelBuilder.Entity<RfStatus>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<SgifDatosArtículos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SGIF_Datos Artículos");

                entity.Property(e => e.EsDrog).IsUnicode(false);
            });

            modelBuilder.Entity<SgifInventarioVendible>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SGIF_Inventario Vendible");

                entity.Property(e => e.EsDrog).IsUnicode(false);
            });

            modelBuilder.Entity<Sicajmov>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.IdTr)
                    .HasName("SICAJMOV$id_tr")
                    .IsUnique();

                entity.Property(e => e.DocAp).HasDefaultValueSql("((0))");

                entity.Property(e => e.DocCi).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdTr).ValueGeneratedOnAdd();

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.SaldoAp).HasDefaultValueSql("((0))");

                entity.Property(e => e.SaldoCi).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Vendedor).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Siciudad>(entity =>
            {
                entity.HasKey(e => e.CodCi)
                    .HasName("SICIUDAD$PrimaryKey");
            });

            modelBuilder.Entity<Siclases>(entity =>
            {
                entity.HasKey(e => e.CodigoCla)
                    .HasName("SICLASES$PrimaryKey");
            });

            modelBuilder.Entity<Sicltera>(entity =>
            {
                entity.HasKey(e => e.CodClTer)
                    .HasName("SICLTERA$PrimaryKey");
            });

            modelBuilder.Entity<Sicobrad>(entity =>
            {
                entity.HasKey(e => e.CodCob)
                    .HasName("SICOBRAD$PrimaryKey");
            });

            modelBuilder.Entity<Sicoment>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Clave)
                    .HasName("SICOMENT$Clave");

                entity.HasIndex(e => e.Fecha)
                    .HasName("SICOMENT$Fecha");

                entity.HasIndex(e => e.Módulo)
                    .HasName("SICOMENT$Módulo");
            });

            modelBuilder.Entity<Sicomuna>(entity =>
            {
                entity.HasKey(e => e.Codcom)
                    .HasName("SICOMUNA$PrimaryKey");
            });

            modelBuilder.Entity<SicomunaDatos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SICOMUNA Datos");
            });

            modelBuilder.Entity<Siconcam>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Sidusers>(entity =>
            {
                entity.HasKey(e => e.User)
                    .HasName("SIDUSERS$PrimaryKey");

                entity.Property(e => e.Sm312).HasDefaultValueSql("('N')");

                entity.Property(e => e.Sm40117).HasDefaultValueSql("('N')");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Siforfar>(entity =>
            {
                entity.HasKey(e => e.CodigoFfa)
                    .HasName("SIFORFAR$PrimaryKey");
            });

            modelBuilder.Entity<Sifpagos>(entity =>
            {
                entity.HasKey(e => e.Codfp)
                    .HasName("SIFPAGOS$PrimaryKey");

                entity.Property(e => e.Descuento).HasDefaultValueSql("((0))");

                entity.Property(e => e.Dias1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Dias2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Dias3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Dias4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Dias5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Dias6).HasDefaultValueSql("((0))");

                entity.Property(e => e.FpDte).HasDefaultValueSql("((0))");

                entity.Property(e => e.RetNv).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Sigirosr>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Sigruaso>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.CodArt)
                    .HasName("SIGRUASO$codigob");

                entity.HasIndex(e => e.CodGrupo)
                    .HasName("SIGRUASO$codigop");

                entity.HasIndex(e => new { e.CodArt, e.CodGrupo })
                    .HasName("SIGRUASO$codigob_codigop");
            });

            modelBuilder.Entity<Sigrupos>(entity =>
            {
                entity.HasKey(e => e.CodGrupo)
                    .HasName("SIGRUPOS$PrimaryKey");
            });

            modelBuilder.Entity<Simacodb>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Codigob)
                    .HasName("SIMACODB$codigob")
                    .IsUnique();

                entity.HasIndex(e => e.Codigop)
                    .HasName("SIMACODB$codigop");

                entity.HasIndex(e => e.Laboratorio)
                    .HasName("SIMACODB$laboratorio");

                entity.Property(e => e.Alto).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ancho).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bioequivalente).HasDefaultValueSql("((0))");

                entity.Property(e => e.Largo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Peso).HasDefaultValueSql("((0))");

                entity.Property(e => e.Principal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UnFin).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnIni).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SimacodbBuscarDuplicados>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SIMACODB Buscar duplicados");
            });

            modelBuilder.Entity<Simaerut>(entity =>
            {
                entity.HasKey(e => e.Rutpro)
                    .HasName("SIMAERUT$PrimaryKey");

                entity.HasIndex(e => e.Canal)
                    .HasName("SIMAERUT$ICanal");

                entity.HasIndex(e => e.Ciudad)
                    .HasName("SIMAERUT$ciudad");

                entity.HasIndex(e => e.Codigoi)
                    .HasName("SIMAERUT$codigoi");

                entity.HasIndex(e => e.Comuna)
                    .HasName("SIMAERUT$comuna");

                entity.HasIndex(e => e.Estado)
                    .HasName("SIMAERUT$Estado");

                entity.HasIndex(e => e.Fpago)
                    .HasName("SIMAERUT$pago");

                entity.HasIndex(e => e.Giro)
                    .HasName("SIMAERUT$Giro");

                entity.HasIndex(e => e.Identificador)
                    .HasName("SIMAERUT$identificador");

                entity.HasIndex(e => e.TipVen)
                    .HasName("SIMAERUT$Tipo_Venta");

                entity.HasIndex(e => e.TipoCli)
                    .HasName("SIMAERUT$Tipo_Cliente");

                entity.HasIndex(e => e.Vendedor)
                    .HasName("SIMAERUT$vendedor");

                entity.HasIndex(e => e.Zona)
                    .HasName("SIMAERUT$IZona");

                entity.Property(e => e.Codigoi).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cupo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Descuento).HasDefaultValueSql("((0))");

                entity.Property(e => e.DíasCanje).HasDefaultValueSql("((0))");

                entity.Property(e => e.Envío).HasDefaultValueSql("((0))");

                entity.Property(e => e.EsCenAbast).HasDefaultValueSql("((0))");

                entity.Property(e => e.EsRetail).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fdet).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fres).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gdes).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gint).HasDefaultValueSql("((0))");

                entity.Property(e => e.Recargo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Resol).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TipoRut).HasComment("N: Nacional E:extranjero");

                entity.Property(e => e.Vend).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SimaerutClientes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SIMAERUT Clientes");
            });

            modelBuilder.Entity<Simalabo>(entity =>
            {
                entity.HasKey(e => e.CodigoLab)
                    .HasName("SIMALABO$PrimaryKey");

                entity.Property(e => e.Tipo).HasDefaultValueSql("('R')");
            });

            modelBuilder.Entity<Simaprod>(entity =>
            {
                entity.HasKey(e => e.CodigoMat)
                    .HasName("SIMAPROD$articulo");

                entity.HasIndex(e => e.ClTerap)
                    .HasName("SIMAPROD$Clase_Terapéutica");

                entity.HasIndex(e => e.Clase)
                    .HasName("SIMAPROD$clase");

                entity.HasIndex(e => e.CodTcom)
                    .HasName("SIMAPROD$Tipo_Comercial");

                entity.HasIndex(e => e.Forfar)
                    .HasName("SIMAPROD$Forma_Farmacéutica");

                entity.HasIndex(e => e.IdProv)
                    .HasName("SIMAPROD$Id_Prov");

                entity.HasIndex(e => e.Indice)
                    .HasName("SIMAPROD$descrip");

                entity.HasIndex(e => e.Labo)
                    .HasName("SIMAPROD$labo");

                entity.HasIndex(e => e.PrActivo1)
                    .HasName("SIMAPROD$Principio_Activo");

                entity.HasIndex(e => e.Subclase)
                    .HasName("SIMAPROD$subclase");

                entity.Property(e => e.Clasif).HasComment("A,B,C,D,E,F,N");

                entity.Property(e => e.Clasificacion).HasComment("FLAG QUE INDICA SI EL PRODUCTO ES PRODUCIDO COMPRADO O AMBAS P,C,A");

                entity.Property(e => e.CodFran).HasDefaultValueSql("('T')");

                entity.Property(e => e.Codbarra).HasComment("FLAG QUE INDICA SI EL PRODUCTO APARECE COMO AYUDA DE CODIGOS DE BARRA");

                entity.Property(e => e.Cons1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cons2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cons3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cons4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cons5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cons6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Contiene).HasDefaultValueSql("((0))");

                entity.Property(e => e.Controlado).HasComment("FLAG QUE INDICA SI EL PRODUCTO ES CONTROLADO  S,N");

                entity.Property(e => e.DesPorc).HasDefaultValueSql("((0))");

                entity.Property(e => e.DescriCom).HasComment("DESCRIPCION ADICIONAL QUE APARECERA EN LAS ORDENES DE COMPRA, SI EXISTE");

                entity.Property(e => e.DescriRes).HasComment("DESCRIPCION QUE APARECERA EN LOS VALES DE VENTA O FACTURA ELECTRONICA");

                entity.Property(e => e.Empaque).HasDefaultValueSql("((0))");

                entity.Property(e => e.Estado).HasComment("A: ACTIVO B: BLOQUEADO");

                entity.Property(e => e.Farma).HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaC).HasComment("FECHA DE CREACION DEL CODIGO");

                entity.Property(e => e.FechaD).HasComment("FECHA EN QUE SE DIO DE BAJA EL CODIGO");

                entity.Property(e => e.Forfar).HasComment("CODIGO DE AL FORMA FARMACEUTICA");

                entity.Property(e => e.IdProv).HasDefaultValueSql("((0))");

                entity.Property(e => e.IncPorc).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lotec).HasComment("LOTE DE COMPRA EXPRESADO EN MESES DE VENTA");

                entity.Property(e => e.PendRec).HasDefaultValueSql("((0))");

                entity.Property(e => e.Peso).HasDefaultValueSql("((0))");

                entity.Property(e => e.PetMinimo).HasDefaultValueSql("('N')");

                entity.Property(e => e.PrOferta).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrPortal).HasDefaultValueSql("((0))");

                entity.Property(e => e.Practivo)
                    .HasDefaultValueSql("('N')")
                    .HasComment("FLAG QUE INDICA SI ES PRINCIPIO ACTIVO S,N");

                entity.Property(e => e.PrecioRef).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioVenAnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StkmaxMat).HasComment("STOCK MAXIMO EXPRESADO EN MESES DE VENTA PROMEDIO");

                entity.Property(e => e.StkminMat).HasComment("STOCK MINIMO EXPRESADO EN MESES DE VENTA PROMEDIO");

                entity.Property(e => e.StkrepMat).HasComment("STOCK DE REPOSICION EXPRESADO EN MESES DE VENTA PROMEDIO");

                entity.Property(e => e.Supervisado).HasDefaultValueSql("('N')");

                entity.Property(e => e.Tiempor).HasComment("TIEMPO DE REPOSICION EN DIAS DE UN PRODUCTO");

                entity.Property(e => e.TipoV).HasDefaultValueSql("('T')");

                entity.Property(e => e.Ventap).HasComment("UNIDADES DE VENTA PROMEDIO MENSUAL");
            });

            modelBuilder.Entity<SimaprodPrecioRef0YPrecioVen0>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SIMAPROD Precio_Ref<>0 y Precio_Ven=0");
            });

            modelBuilder.Entity<SimaprodProductos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SIMAPROD Productos");
            });

            modelBuilder.Entity<SimaprodVentas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SIMAPROD Ventas");
            });

            modelBuilder.Entity<Simoncon>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Simoneda>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Simotivo>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Sipaises>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Siparamg>(entity =>
            {
                entity.HasKey(e => e.Clave)
                    .HasName("SIPARAMG$PrimaryKey");

                entity.HasIndex(e => e.Clave)
                    .HasName("SIPARAMG$CLAVE");
            });

            modelBuilder.Entity<Sipracti>(entity =>
            {
                entity.HasKey(e => e.CodPrAct)
                    .HasName("SIPRACTI$PrimaryKey");
            });

            modelBuilder.Entity<Sirutcon>(entity =>
            {
                entity.HasKey(e => e.Flag)
                    .HasName("SIRUTCON$PrimaryKey");

                entity.HasIndex(e => e.Ciudad)
                    .HasName("SIRUTCON$CIUDAD");

                entity.HasIndex(e => e.Comuna)
                    .HasName("SIRUTCON$COMUNA");

                entity.HasIndex(e => e.Rutpro)
                    .HasName("SIRUTCON$RUTPRO");

                entity.Property(e => e.Flag).ValueGeneratedNever();
            });

            modelBuilder.Entity<Sirutdir>(entity =>
            {
                entity.HasKey(e => e.Flag)
                    .HasName("SIRUTDIR$PrimaryKey");

                entity.HasIndex(e => e.Ciudad)
                    .HasName("SIRUTDIR$CIUDAD");

                entity.HasIndex(e => e.Comuna)
                    .HasName("SIRUTDIR$COMUNA");

                entity.HasIndex(e => e.Rutpro)
                    .HasName("SIRUTDIR$RUTPRO");

                entity.Property(e => e.Flag).ValueGeneratedNever();
            });

            modelBuilder.Entity<Sirutrsn>(entity =>
            {
                entity.HasKey(e => e.Flag)
                    .HasName("SIRUTRSN$PrimaryKey");

                entity.HasIndex(e => e.Ciudad)
                    .HasName("SIRUTRSN$CIUDAD");

                entity.HasIndex(e => e.Comuna)
                    .HasName("SIRUTRSN$COMUNA");

                entity.HasIndex(e => e.Rutpro)
                    .HasName("SIRUTRSN$RUTPRO");

                entity.Property(e => e.Flag).ValueGeneratedNever();
            });

            modelBuilder.Entity<Sisubcla>(entity =>
            {
                entity.HasKey(e => e.CodigoScl)
                    .HasName("SISUBCLA$PrimaryKey");
            });

            modelBuilder.Entity<Sitipcom>(entity =>
            {
                entity.HasKey(e => e.CodTcom)
                    .HasName("SITIPCOM$PrimaryKey");
            });

            modelBuilder.Entity<Siunicon>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Factorc).HasDefaultValueSql("((1))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Siunidad>(entity =>
            {
                entity.HasKey(e => e.Coduni)
                    .HasName("SIUNIDAD$PrimaryKey");
            });

            modelBuilder.Entity<StatusNventa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StatusNVenta");
            });

            modelBuilder.Entity<SysDmAuditActions>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Vecotdet>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.NumCot)
                    .HasName("VECOTDET$NumCot_20200202-204351")
                    .IsClustered();

                entity.Property(e => e.Cant).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantPed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Costo).HasDefaultValueSql("((0))");

                entity.Property(e => e.NumLin).HasDefaultValueSql("((0))");

                entity.Property(e => e.Precio).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ValorT).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Vecotenc>(entity =>
            {
                entity.HasKey(e => e.NumCot)
                    .HasName("VECOTENC$PrimaryKey");

                entity.Property(e => e.AfEx).HasComment("A: Afecta, E:Exenta");

                entity.Property(e => e.Estado).HasComment("A: Abierta; G: Generada; C: Cerrada; P:Parcial; N: Anulada");

                entity.Property(e => e.Iva).HasDefaultValueSql("((0))");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Vend).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Veguidet>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Codmp)
                    .HasName("VEGUIDET$codmp");

                entity.HasIndex(e => e.EstGuia)
                    .HasName("VEGUIDET$estguia");

                entity.HasIndex(e => e.Lote)
                    .HasName("VEGUIDET$lote");

                entity.HasIndex(e => e.NumGuia)
                    .HasName("VEGUIDET$NumGuia");

                entity.HasIndex(e => e.Ubicacion)
                    .HasName("VEGUIDET$Ubicación");

                entity.Property(e => e.CantFact).HasDefaultValueSql("((0))");

                entity.Property(e => e.Costop).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinPed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nc).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioP).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<VeguidetEliminaDatos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VEGUIDET Elimina Datos");

                entity.Property(e => e.Codigob).IsUnicode(false);

                entity.Property(e => e.Codmp).IsUnicode(false);

                entity.Property(e => e.Coduni).IsUnicode(false);

                entity.Property(e => e.Codunir).IsUnicode(false);

                entity.Property(e => e.EsNc).IsUnicode(false);

                entity.Property(e => e.EstGuia).IsUnicode(false);

                entity.Property(e => e.Lote).IsUnicode(false);

                entity.Property(e => e.Motivo).IsUnicode(false);

                entity.Property(e => e.NumGuia).IsUnicode(false);

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Ubicacion).IsUnicode(false);
            });

            modelBuilder.Entity<Veguienc>(entity =>
            {
                entity.HasKey(e => e.NumGuia)
                    .HasName("VEGUIENC$PrimaryKey");

                entity.HasIndex(e => e.EstGuia)
                    .HasName("VEGUIENC$estado_guia");

                entity.HasIndex(e => e.EstVenta)
                    .HasName("VEGUIENC$estado_venta");

                entity.HasIndex(e => e.Estado)
                    .HasName("VEGUIENC$estado");

                entity.HasIndex(e => e.FacturarA)
                    .HasName("VEGUIENC$FacturarA");

                entity.HasIndex(e => e.Fecha)
                    .HasName("VEGUIENC$fecha");

                entity.HasIndex(e => e.NumFac)
                    .HasName("VEGUIENC$Factura");

                entity.HasIndex(e => e.NumPed)
                    .HasName("VEGUIENC$Pedido");

                entity.HasIndex(e => e.RutCli)
                    .HasName("VEGUIENC$rutcli");

                entity.HasIndex(e => e.TipoGuía)
                    .HasName("VEGUIENC$tipo");

                entity.HasIndex(e => e.Vendedor)
                    .HasName("VEGUIENC$vendedor");

                entity.Property(e => e.DespacharA)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Codigo sociado a direccion de despacho");

                entity.Property(e => e.Dte)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0; NO 1: si documento tributario electrònico creado 2-10-2014");

                entity.Property(e => e.FacturarA).HasDefaultValueSql("((0))");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vendedor).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Velicdet>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.CodBase)
                    .HasName("VELICDET$codbase");

                entity.HasIndex(e => e.Estado)
                    .HasName("VELICDET$estado");

                entity.HasIndex(e => e.FecLic)
                    .HasName("VELICDET$fecped");

                entity.HasIndex(e => e.Idlic)
                    .HasName("VELICDET$numped");

                entity.HasIndex(e => e.NumLin)
                    .HasName("VELICDET$numlin");

                entity.Property(e => e.CantDesp).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantLic).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantNc).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantNd).HasDefaultValueSql("((0))");

                entity.Property(e => e.Costo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Saldo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Velicenc>(entity =>
            {
                entity.HasKey(e => e.Idlic)
                    .HasName("VELICENC$PrimaryKey");

                entity.HasIndex(e => e.Canal)
                    .HasName("VELICENC$Canal");

                entity.HasIndex(e => e.Estado)
                    .HasName("VELICENC$estado");

                entity.HasIndex(e => e.FecLic)
                    .HasName("VELICENC$fecped");

                entity.HasIndex(e => e.Local)
                    .HasName("VELICENC$Local");

                entity.HasIndex(e => e.RutCli)
                    .HasName("VELICENC$rutcli");

                entity.HasIndex(e => e.Vend)
                    .HasName("VELICENC$Vendedor");

                entity.Property(e => e.Duración).HasDefaultValueSql("((0))");

                entity.Property(e => e.Estado).HasComment("A: Abierta; G: Generada; C: Cerrada; P:Parcial; N: Anulada");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vend).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Velispre>(entity =>
            {
                entity.HasKey(e => e.CodLp)
                    .HasName("VELISPRE$PrimaryKey");

                entity.Property(e => e.Factor).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Velispva>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.CodLp)
                    .HasName("VELISPVA$Código");

                entity.HasIndex(e => e.CodPro)
                    .HasName("VELISPVA$Producto");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Vneto).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Velocbod>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Codlocal).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Velocven>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CodVen).HasDefaultValueSql("((0))");

                entity.Property(e => e.Codlocal).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Vemcajas>(entity =>
            {
                entity.HasKey(e => e.CodCaja)
                    .HasName("VEMCAJAS$PrimaryKey");
            });

            modelBuilder.Entity<Vemcanal>(entity =>
            {
                entity.HasKey(e => e.CodCanal)
                    .HasName("VEMCANAL$PrimaryKey");
            });

            modelBuilder.Entity<Vemlocal>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LocCod).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Vemventa>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Clave01)
                    .HasName("VEMVENTA$clave01");

                entity.HasIndex(e => e.Codmp)
                    .HasName("VEMVENTA$codmp");

                entity.HasIndex(e => e.Folio)
                    .HasName("VEMVENTA$CLAVE");

                entity.HasIndex(e => e.Tipo)
                    .HasName("VEMVENTA$tipo");

                entity.Property(e => e.Clave01).HasComment("Clave para acelerar listados de Venta");

                entity.Property(e => e.Costop).HasDefaultValueSql("((0))");

                entity.Property(e => e.Factorv).HasDefaultValueSql("((1))");

                entity.Property(e => e.Incp).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nc).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nd).HasDefaultValueSql("((0))");

                entity.Property(e => e.Porcd).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrFinal).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrOferta).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrReferencia).HasDefaultValueSql("((0))");

                entity.Property(e => e.Precio).HasDefaultValueSql("((0))");

                entity.Property(e => e.Qreal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Valord).HasDefaultValueSql("((0))");

                entity.Property(e => e.Valori).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Vemzonas>(entity =>
            {
                entity.HasKey(e => e.CodZona)
                    .HasName("VEMZONAS$PrimaryKey");
            });

            modelBuilder.Entity<Venotdet>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.NumDoc)
                    .HasName("VENOTDET$NumDoc");

                entity.HasIndex(e => e.Tipo)
                    .HasName("VENOTDET$Tipo");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Tipo).HasComment("C: Nota de Crédito D: Nota de Débito");
            });

            modelBuilder.Entity<Venovent>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Folio)
                    .HasName("VENOVENT$FOLIO");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("((0))");

                entity.Property(e => e.Local)
                    .HasDefaultValueSql("((0))")
                    .HasComment("TIPO DE DOCUMENTO CON  QUE LLEGA F,G,O (FACTURA, GUIA, OTRA)");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Vendedor).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ventatem>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("VENTATEM$CODIGO");

                entity.Property(e => e.Sal1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sal10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sal11).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sal12).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sal2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sal3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sal4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sal5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sal6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sal7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sal8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sal9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Vepeddet>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.CodBase)
                    .HasName("VEPEDDET$codbase");

                entity.HasIndex(e => e.Estado)
                    .HasName("VEPEDDET$estado");

                entity.HasIndex(e => e.FecPed)
                    .HasName("VEPEDDET$fecped");

                entity.HasIndex(e => e.NumLin)
                    .HasName("VEPEDDET$numlin");

                entity.HasIndex(e => e.NumPed)
                    .HasName("VEPEDDET$numped");

                entity.Property(e => e.CantFact).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantGuia).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantNc).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantNd).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantPrep).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantRes).HasDefaultValueSql("((0))");

                entity.Property(e => e.CantVir).HasDefaultValueSql("((0))");

                entity.Property(e => e.Costo).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecEsp).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecOf).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecRef).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<VepeddetCantPrepCantres>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VEPEDDET CantPrep>Cantres");
            });

            modelBuilder.Entity<VepeddetGuiaReserva>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VEPEDDET Guia>Reserva");
            });

            modelBuilder.Entity<VepeddetProducto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VEPEDDET Producto");
            });

            modelBuilder.Entity<Vepedenc>(entity =>
            {
                entity.HasKey(e => e.NumPed)
                    .HasName("VEPEDENC$PrimaryKey");

                entity.HasIndex(e => e.Canal)
                    .HasName("VEPEDENC$Canal");

                entity.HasIndex(e => e.Direcc)
                    .HasName("VEPEDENC$Dirección");

                entity.HasIndex(e => e.Estado)
                    .HasName("VEPEDENC$estado");

                entity.HasIndex(e => e.FacturarA)
                    .HasName("VEPEDENC$FacturarA");

                entity.HasIndex(e => e.FecPed)
                    .HasName("VEPEDENC$fecped");

                entity.HasIndex(e => e.Fpago)
                    .HasName("VEPEDENC$Forma_de_Pago");

                entity.HasIndex(e => e.Idlic)
                    .HasName("VEPEDENC$IDLic");

                entity.HasIndex(e => e.Local)
                    .HasName("VEPEDENC$Local");

                entity.HasIndex(e => e.OrdC)
                    .HasName("VEPEDENC$Orden de Compra");

                entity.HasIndex(e => e.RutCli)
                    .HasName("VEPEDENC$rutcli");

                entity.HasIndex(e => e.TipCli)
                    .HasName("VEPEDENC$Tipo_Cliente");

                entity.HasIndex(e => e.Vend)
                    .HasName("VEPEDENC$Vendedor");

                entity.HasIndex(e => e.Zona)
                    .HasName("VEPEDENC$Zona");

                entity.Property(e => e.AfEx).HasComment("A: Afecta, E:Exenta");

                entity.Property(e => e.Direcc).HasDefaultValueSql("((0))");

                entity.Property(e => e.Estado).HasComment("A: Abierta; G: Generada; C: Cerrada; P:Parcial; N: Anulada");

                entity.Property(e => e.FacturarA).HasDefaultValueSql("((0))");

                entity.Property(e => e.FecEnt).HasComment("Fecha de Entrega Pedido 2-3-2015");

                entity.Property(e => e.Flete).HasDefaultValueSql("((0))");

                entity.Property(e => e.FolCon).HasComment("Folio Controlados 2-3-2015");

                entity.Property(e => e.Iva).HasDefaultValueSql("((0))");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoFact).HasDefaultValueSql("('N')");

                entity.Property(e => e.Parcial)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0: No 1: Sí");

                entity.Property(e => e.Retenido)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0: No 1: Sí");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Unidades).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vend).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Vetclbod>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.CodTcli)
                    .HasName("VETCLBOD$Tipo Cliente");

                entity.HasIndex(e => e.Codbod)
                    .HasName("VETCLBOD$Bodega");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Vetipcli>(entity =>
            {
                entity.HasKey(e => e.CodTcli)
                    .HasName("VETIPCLI$PrimaryKey");
            });

            modelBuilder.Entity<Vetipven>(entity =>
            {
                entity.HasKey(e => e.CodTven)
                    .HasName("VETIPVEN$PrimaryKey");
            });

            modelBuilder.Entity<Vevenenc>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.AsignaTr)
                    .HasName("VEVENENC$Asigna_Tr(Non-Unique,Non-Clustered)");

                entity.HasIndex(e => e.Clave01)
                    .HasName("VEVENENC$Clave01 (Unique,Clustered)")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.Codbod)
                    .HasName("VEVENENC$Bodega");

                entity.HasIndex(e => e.Estado)
                    .HasName("VEVENENC$Estado");

                entity.HasIndex(e => e.Fecha)
                    .HasName("VEVENENC$fecha");

                entity.HasIndex(e => e.Folio)
                    .HasName("VEVENENC$folio");

                entity.HasIndex(e => e.NumGui)
                    .HasName("VEVENENC$numgui");

                entity.HasIndex(e => e.NumPed)
                    .HasName("VEVENENC$numped");

                entity.HasIndex(e => e.RutCliente)
                    .HasName("VEVENENC$rut_cliente");

                entity.HasIndex(e => e.Saldada)
                    .HasName("VEVENENC$saldada-20200224-131957");

                entity.HasIndex(e => e.Tipo)
                    .HasName("VEVENENC$Tipo");

                entity.HasIndex(e => e.Vendedor)
                    .HasName("VEVENENC$VENDEDOR");

                entity.Property(e => e.Clave01).HasComment("2-3-2015 Clave para acelerar listados de Venta");

                entity.Property(e => e.DesCli).HasDefaultValueSql("((0))");

                entity.Property(e => e.Descfp).HasDefaultValueSql("((0))");

                entity.Property(e => e.Descuento).HasDefaultValueSql("((0))");

                entity.Property(e => e.DescuentoAd).HasDefaultValueSql("((0))");

                entity.Property(e => e.Dte).HasDefaultValueSql("((0))");

                entity.Property(e => e.Estado).HasComment("ESTADO V,A");

                entity.Property(e => e.Fechaa).HasComment("FECHA DE LA ANULACION");

                entity.Property(e => e.Iva).HasDefaultValueSql("((0))");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ncval).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ndval).HasDefaultValueSql("((0))");

                entity.Property(e => e.Neto).HasDefaultValueSql("((0))");

                entity.Property(e => e.PdesCli).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecCli).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecCli).HasDefaultValueSql("((0))");

                entity.Property(e => e.Saldada).HasDefaultValueSql("(N'N')");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Subtotal).HasDefaultValueSql("((0))");

                entity.Property(e => e.Total).HasDefaultValueSql("((0))");

                entity.Property(e => e.Usuarioa).HasComment("USUARIO QUIEN REALIZA LA ANULACION");

                entity.Property(e => e.Vendedor).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<VevenencVenta2017>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VEVENENC Venta 2017");
            });

            modelBuilder.Entity<VevenencVentaHistórica>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VEVENENC Venta Histórica");
            });

            modelBuilder.Entity<Vezonatr>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.TrCod)
                    .HasName("VEZONATR$Transporte");

                entity.HasIndex(e => e.ZnCod)
                    .HasName("VEZONATR$Zona");

                entity.HasIndex(e => e.Zona)
                    .HasName("VEZONATR$ZONAS");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ZCarga>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cuc).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pofer).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ppub).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ZCargaGetransp>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Boleto)
                    .HasName("z_Carga_GETRANSP$Boleto");

                entity.HasIndex(e => e.Factura)
                    .HasName("z_Carga_GETRANSP$Factura");

                entity.HasIndex(e => e.NumGuia)
                    .HasName("z_Carga_GETRANSP$Guía");

                entity.HasIndex(e => e.Trans)
                    .HasName("z_Carga_GETRANSP$Trans");

                entity.HasIndex(e => e.Transporte)
                    .HasName("z_Carga_GETRANSP$Transporte");

                entity.Property(e => e.Alto).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ancho).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bultos).HasDefaultValueSql("((0))");

                entity.Property(e => e.EnRuta).HasDefaultValueSql("((0))");

                entity.Property(e => e.Flete).HasDefaultValueSql("((0))");

                entity.Property(e => e.Largo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Local).HasDefaultValueSql("((0))");

                entity.Property(e => e.Peso).HasDefaultValueSql("((0))");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Trans).HasComment("I INterno L:Lit P: Prosegur");

                entity.Property(e => e.ValorDe).HasDefaultValueSql("((0))");

                entity.Property(e => e.Volumen).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ZCargaRut>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Cmon)
                    .HasName("Z_Carga_Rut$Moneda");

                entity.HasIndex(e => e.Codigoi)
                    .HasName("Z_Carga_Rut$codigoi");

                entity.HasIndex(e => e.Identificador)
                    .HasName("Z_Carga_Rut$identificador");

                entity.HasIndex(e => e.Rutpro)
                    .HasName("Z_Carga_Rut$rutpro");

                entity.Property(e => e.Codigoi).HasDefaultValueSql("((0))");

                entity.Property(e => e.Descuento).HasDefaultValueSql("((0))");

                entity.Property(e => e.Recargo).HasDefaultValueSql("((0))");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Vend).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ZFarma>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Farma).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ZInformeVentas>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Código)
                    .HasName("z_Informe_Ventas$Código");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ZVentasListadoVendedores>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Z_VENTAS Listado Vendedores");

                entity.Property(e => e.Condición).IsUnicode(false);
            });

            modelBuilder.Entity<ZxCantidadLineasporNotadeventaFacturadas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_CantidadLineasporNotadeventaFacturadas");
            });

            modelBuilder.Entity<ZxCantidaddeitemenpreparacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_Cantidaddeitemenpreparacion");
            });

            modelBuilder.Entity<ZxClientes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ZX_Clientes");
            });

            modelBuilder.Entity<ZxConsolidadoImpreped>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_ConsolidadoImpreped");
            });

            modelBuilder.Entity<ZxCountPreparaciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_CountPreparaciones");
            });

            modelBuilder.Entity<ZxCoutDfact>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_CoutDFact");
            });

            modelBuilder.Entity<ZxDatosDespacho>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_DatosDespacho");
            });

            modelBuilder.Entity<ZxEsFarma>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ZX_EsFarma");
            });

            modelBuilder.Entity<ZxFacturado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_Facturado");
            });

            modelBuilder.Entity<ZxFechasDespachos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_fechasDespachos");
            });

            modelBuilder.Entity<ZxGuiayPreparacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_guiayPreparacion");
            });

            modelBuilder.Entity<ZxInvRotacionVencimiento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zx_Inv_Rotacion_Vencimiento");
            });

            modelBuilder.Entity<ZxItemsFacturados>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_ItemsFacturados");
            });

            modelBuilder.Entity<ZxLineasPreparas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_LineasPreparas");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.EstadoDeProceso).IsUnicode(false);
            });

            modelBuilder.Entity<ZxListadoVendedores>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_ListadoVendedores");
            });

            modelBuilder.Entity<ZxMovimientodeInventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_MovimientodeInventario");
            });

            modelBuilder.Entity<ZxNotadeVentasStatus1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ZX_NotadeVentasStatus1");

                entity.Property(e => e.Estado).IsUnicode(false);
            });

            modelBuilder.Entity<ZxNotadeVentasStatus2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_NotadeVentasStatus2");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<ZxNvdiarias>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_NVDiarias");
            });

            modelBuilder.Entity<ZxPickingAreaP>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ZX_PickingAreaP");
            });

            modelBuilder.Entity<ZxPreparacionLg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ZX_PreparacionLG");

                entity.Property(e => e.Sddoco).IsUnicode(false);
            });

            modelBuilder.Entity<ZxProdUbicaciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_Prod_Ubicaciones");
            });

            modelBuilder.Entity<ZxRotaciondeInventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx-RotaciondeInventario");
            });

            modelBuilder.Entity<ZxStatusdeNv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_statusdeNV");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<ZxTiempoPreparacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zx_TiempoPreparacion");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<ZxTipoBodega>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_TipoBodega");
            });

            modelBuilder.Entity<ZxTrasportesTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_TrasportesTime");
            });

            modelBuilder.Entity<ZxVenta>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_Venta");
            });

            modelBuilder.Entity<ZxVentaporPreparacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Zx_VentaporPreparacion");
            });

            modelBuilder.Entity<ZzSysCfFactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_CF_Factura");
            });

            modelBuilder.Entity<ZzSysGuíaComprasAnual>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_Guía_Compras_Anual");
            });

            modelBuilder.Entity<ZzSysGuíaProductoUn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_Guía_Producto_UN");
            });

            modelBuilder.Entity<ZzSysInventarioVendible>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_Inventario Vendible");
            });

            modelBuilder.Entity<ZzSysIqviaEst>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_iqvia_est");

                entity.Property(e => e.Tipo).IsUnicode(false);
            });

            modelBuilder.Entity<ZzSysNcComprasAnual>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_NC_Compras_Anual");
            });

            modelBuilder.Entity<ZzSysNcFactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_NC_Factura");
            });

            modelBuilder.Entity<ZzSysNcProductoUn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_NC_Producto_UN");
            });

            modelBuilder.Entity<ZzSysNdFactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_ND_Factura");
            });

            modelBuilder.Entity<ZzSysNdProductoUn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_ND_Producto_UN");
            });

            modelBuilder.Entity<ZzSysNotasDeVentaClientesPendientes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_Notas de Venta Clientes Pendientes");
            });

            modelBuilder.Entity<ZzSysNotasDeVentaPendientes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_Notas de Venta Pendientes");
            });

            modelBuilder.Entity<ZzSysNotasDeVentaRepaso>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_Notas de Venta Repaso");
            });

            modelBuilder.Entity<ZzSysNotasDeVentaRepasoProducto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_Notas de Venta Repaso Producto");
            });

            modelBuilder.Entity<ZzSysOrdenesDeCompraPendientes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_Ordenes de Compra Pendientes");
            });

            modelBuilder.Entity<ZzSysPagosFactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_Pagos_Factura");
            });

            modelBuilder.Entity<ZzSysPetitorioInventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_Petitorio_Inventario");
            });

            modelBuilder.Entity<ZzSysVentasPeríodo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_Sys_Ventas_Período");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
