using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZxClientes
    {
        [StringLength(10)]
        public string NumPed { get; set; }
        [Column("IDENTIFICADOR")]
        [StringLength(80)]
        public string Identificador { get; set; }
        [Column("COMUNA")]
        [StringLength(4)]
        public string Comuna { get; set; }
        [Column("CIUDAD")]
        [StringLength(4)]
        public string Ciudad { get; set; }
        [StringLength(35)]
        public string DesCanal { get; set; }
        [StringLength(4)]
        public string TipoCli { get; set; }
        [StringLength(4)]
        public string Canal { get; set; }
        [Column("NOMCOM")]
        [StringLength(35)]
        public string Nomcom { get; set; }
        [Column("ZONACOM")]
        [StringLength(2)]
        public string Zonacom { get; set; }
        [StringLength(35)]
        public string NomCi { get; set; }
        [Column("Cod_Per")]
        [StringLength(4)]
        public string CodPer { get; set; }
        [Column("Des_Per")]
        [StringLength(35)]
        public string DesPer { get; set; }
        [Column("FOLIO")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("BODEGA")]
        [StringLength(4)]
        public string Bodega { get; set; }
    }
}
