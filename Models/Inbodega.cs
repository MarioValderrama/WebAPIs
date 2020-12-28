using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("INBODEGA")]
    public partial class Inbodega
    {
        [Key]
        [Column("CODIGO_BOD")]
        [StringLength(3)]
        public string CodigoBod { get; set; }
        [Column("DESCRI_BOD")]
        [StringLength(35)]
        public string DescriBod { get; set; }
        [Column("UBICA_BOD")]
        [StringLength(35)]
        public string UbicaBod { get; set; }
        [Column("VENDIBLE")]
        [StringLength(1)]
        public string Vendible { get; set; }
        [Column("LOTES")]
        [StringLength(1)]
        public string Lotes { get; set; }
        [Column("UBICA")]
        [StringLength(1)]
        public string Ubica { get; set; }
        [Column("LISTADO")]
        [StringLength(1)]
        public string Listado { get; set; }
        [Column("Bodega_Grupo")]
        [StringLength(4)]
        public string BodegaGrupo { get; set; }
    }
}
