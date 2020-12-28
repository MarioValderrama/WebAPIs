using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxTipoBodega
    {
        [Column("BODEGA")]
        [StringLength(4)]
        public string Bodega { get; set; }
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
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
    }
}
