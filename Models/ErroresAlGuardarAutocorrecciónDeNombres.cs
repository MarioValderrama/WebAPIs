using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("Errores al guardar Autocorrección de nombres")]
    public partial class ErroresAlGuardarAutocorrecciónDeNombres
    {
        [Column("Nombre del objeto")]
        [StringLength(255)]
        public string NombreDelObjeto { get; set; }
        [Column("Tipo de objeto")]
        [StringLength(255)]
        public string TipoDeObjeto { get; set; }
        [Column("Motivo del error")]
        [StringLength(255)]
        public string MotivoDelError { get; set; }
        [Column(TypeName = "datetime2(0)")]
        public DateTime? Hora { get; set; }
    }
}
